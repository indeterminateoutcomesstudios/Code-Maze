using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavirint
{
    public class Node :INode
    {
        private bool isOpenList = false;
        private bool isClosedList = false;

        public int X { get; private set; }
        public int Y { get; private set; }

        public bool IsWall { get; set; }

        public Labyrinth Grid;

        public Node(Labyrinth grid, int x, int y, bool isWall)
        {
            Grid = grid;
            X = x;
            Y = y;
            IsWall = isWall;
        }

        /// <summary>
        /// Gets or sets whether this node is on the open list.
        /// </summary>
        public bool IsOpenList(IEnumerable<INode> openList)
        {
            return isOpenList;
        }

        public void SetOpenList(bool value)
        {
            isOpenList = value;
        }

        /// <summary>
        /// If this is a wall then return as unsearchable without ever checking the node.
        /// </summary>
        public bool IsClosedList(IEnumerable<INode> closedList)
        {
            return IsWall || isClosedList;
        }

        public void SetClosedList(bool value)
        {
            isClosedList = value;
        }

        /// <summary>
        /// Gets the total cost for this node.
        /// f = g + h
        /// TotalCost = MovementCost + EstimatedCost
        /// </summary>
        public int TotalCost { get { return MovementCost + EstimatedCost; } }

        /// <summary>
        /// Gets the movement cost for this node.
        /// This is the movement cost from this node to the starting node, or g.
        /// </summary>
        public int MovementCost { get; private set; }

        /// <summary>
        /// Gets the estimated cost for this node.
        /// This is the heuristic from this node to the goal node, or h.
        /// </summary>
        public int EstimatedCost { get; private set; }

        /// <summary>
        /// Parent.MovementCost + 1
        /// </summary>
        /// <param name="parent">Parent node, for access to the parents movement cost.</param>
        public void SetMovementCost(INode parent)
        {
            this.MovementCost = parent.MovementCost + 1;
        }

        /// <summary>
        /// Simple manhatten.
        /// </summary>
        /// <param name="goal">Goal node, for acces to the goals position.</param>
        public void SetEstimatedCost(INode goal)
        {
            var g = (Node)goal;
            this.EstimatedCost = Math.Abs(this.X - g.X) + Math.Abs(this.Y - g.Y);
        }

        /// <summary>
        /// Gets or sets the parent node to this node.
        /// </summary>
        public INode Parent { get; set; }

        // X - 1, Y - 1 | X, Y - 1 | X + 1, Y - 1
        // X - 1, Y     |          | X + 1, Y
        // X - 1, Y + 1 | X, Y + 1 | X + 1, Y + 1
        //private static int[] childXPos = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
        //private static int[] childYPos = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };

        private static int[] childXPos = new int[] { 0, -1, 1, 0, };
        private static int[] childYPos = new int[] { -1, 0, 0, 1, };

        /// <summary>
        /// Gets this node's children.
        /// </summary>
        /// <remarks>The children can be setup in a graph before starting the
        /// A* algorithm or they can be dynamically generated the first time
        /// the A* algorithm calls this property.</remarks>
        public IEnumerable<INode> Children
        {
            get
            {
                var children = new List<Node>();

                /*for (int i = 0; i < childXPos.Length; i++)
                {
                    // skip any nodes out of bounds.
                    if (X + childXPos[i] >= Grid.cols || Y + childYPos[i] >= Grid.rows)
                        continue;
                    if (X + childXPos[i] < 0 || Y + childYPos[i] < 0)
                        continue;

                    children.Add(Grid.MazeofNodes[X + childXPos[i]][Y + childYPos[i]]);
                }*/
                if (X > 0)
                    children.Add(Grid.MazeofNodes[X - 1][Y]);
                if (X < Grid.rows - 1)
                    children.Add(Grid.MazeofNodes[X + 1][Y]);
                if (Y > 0)
                    children.Add(Grid.MazeofNodes[X][Y - 1]);
                if (Y < Grid.cols - 1)
                    children.Add(Grid.MazeofNodes[X][Y + 1]);

                return children;
            }
        }

        /// <summary>
        /// Returns true if this node is the goal, false if it is not the goal.
        /// </summary>
        /// <param name="goal">The goal node to compare this node against.</param>
        /// <returns>True if this node is the goal, false if it s not the goal.</returns>
        public bool IsGoal(INode goal)
        {
            return IsEqual((Node)goal);
        }

        /// <summary>
        /// Two nodes are equal if they share the same spot in the grid.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool IsEqual(Node node)
        {
            return (this == node) || (this.X == node.X && this.Y == node.Y);
        }

        public string Print(Node start, Node goal, IEnumerable<INode> path)
        {
            if (IsWall)
            {
                return "W";
            }
            else if (IsEqual(start))
            {
                return "s";
            }
            else if (IsEqual(goal))
            {
                return "g";
            }
            else if (IsInPath(path))
            {
                return ".";
            }
            else
            {
                return " ";
            }
        }

        private bool IsInPath(IEnumerable<INode> path)
        {
            foreach (var node in path)
            {
                if (IsEqual((Node)node))
                    return true;
            }
            return false;
        }

        public string ToString()
        {
            return String.Format("[{0}][{1}] ", X, Y);
        }
    }
}
