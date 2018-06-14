using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavirint
{
        public enum State
        {
            Searching,
            GoalFound,
            Failed
        }
    
        internal class DuplicateComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return (x <= y) ? -1 : 1;
            }
        }
    
        public class Astar
        {
            private SortedList<int, INode> openList;
            private SortedList<int, INode> closedList;
            private INode current;
            private INode goal;
            public int Steps { get; private set; }
            public IEnumerable<INode> OpenList { get { return openList.Values; } }
            public IEnumerable<INode> ClosedList { get { return closedList.Values; } }
            public INode CurrentNode { get { return current; } }

            public Astar(INode start, INode goal)
            {
                var duplicateComparer = new DuplicateComparer();
                openList = new SortedList<int, INode>(duplicateComparer);
                closedList = new SortedList<int, INode>(duplicateComparer);
                Reset(start, goal);
            }


            public void Reset(INode start, INode goal)
            {
                openList.Clear();
                closedList.Clear();
                current = start;
                this.goal = goal;
                openList.Add(current);
                current.SetOpenList(true);
            }

            public State Run()
            {
                while (true)
                {
                    State s = Step();
                    if (s != State.Searching)
                        return s;
                }
            }

            public State Step()
            {
                Steps++;
                while (true)
                {
                    if (openList.IsEmpty())
                    {
                        return State.Failed;
                    }

                    current = openList.Pop();
                
                    if (current.IsClosedList(ClosedList))
                    {
                        continue;
                    }
                    
                    break;
                }
                
                current.SetOpenList(false);
                closedList.Add(current);
                current.SetClosedList(true);
            
                if (current.IsGoal(goal))
                {
                    return State.GoalFound;
                }
                
                foreach (var child in current.Children)
                {
                    if (child.IsOpenList(OpenList) || child.IsClosedList(ClosedList))
                    {
                        continue;
                    }

                    child.Parent = current;
                    child.SetMovementCost(current);
                    child.SetEstimatedCost(goal);
                    openList.Add(child);
                    child.SetOpenList(true);
                }
                
                return State.Searching;
            }
        
            public IEnumerable<INode> GetPath()
            {
                if (current != null)
                {
                    var next = current;
                    var path = new List<INode>();
                    while (next != null)
                    {
                        path.Add(next);
                        next = next.Parent;
                    }
                    path.Reverse();
                    return path.ToArray();
                }
                return null;
            }
        }
}
