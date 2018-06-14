using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavirint
{

    public class Labyrinth
    {
        Random rand = new Random();
        static Boolean MAZE_WALL = false;
        static Boolean MAZE_PATH = true;

        public int rows;
        public int cols;
        int act_rows;
        int act_cols;

        public Node[][] MazeofNodes;
        public Node Start { get; set; }
        public Node Curret { get; set; }
        public Node Goal { get; set; }

        public Boolean[][] Maze;

        public Labyrinth(int size)
        {
            //initialize instance variables
            rows = size * 2 + 1;
            cols = size * 2 + 1;
            act_rows = size;
            act_cols = size;
            Maze = new Boolean[rows][];

            for (int i = 0; i < rows; i++)
            {
                Maze[i] = new bool[cols]; // Create inner array
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Maze[i][j] = MAZE_PATH;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Maze[i][0] = MAZE_WALL;
                Maze[i][cols - 1] = MAZE_WALL;
            }

            for (int i = 0; i < cols; i++)
            {
                Maze[0][i] = MAZE_WALL;
                Maze[rows - 1][i] = MAZE_WALL;
            }

            MazeofNodes = new Node[rows][];

            for (int i = 0; i < rows; i++)
            {
                MazeofNodes[i] = new Node[cols]; // Create inner array
            }

            makeMaze();
            makeNodes();
        }

        public void makeNodes()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    MazeofNodes[i][j] = new Node(this, i, j, !Maze[i][j]);
                }
            }
            Goal = MazeofNodes[rows - 2][cols - 1];
            Start = MazeofNodes[1][1];
        }

        public void makeMaze(int left, int right, int top, int bottom)
        {
            int width = right - left;
            int height = bottom - top;

            if (width > 2 && height > 2)
            {
                if (width > height)
                    divideVertical(left, right, top, bottom);

                else if (height > width)
                    divideHorizontal(left, right, top, bottom);

                else if (height == width)
                {
                    Boolean pickOne = rand.NextDouble() < 0.5;

                    if (pickOne)
                        divideVertical(left, right, top, bottom);
                    else
                        divideHorizontal(left, right, top, bottom);
                }
            }
            else if (width > 2 && height <= 2)
            {
                divideVertical(left, right, top, bottom);
            }
            else if (width <= 2 && height > 2)
            {
                divideHorizontal(left, right, top, bottom);
            }
        }

        public void makeMaze()
        {
            makeMaze(0, cols - 1, 0, rows - 1);
            makeOpenings();
        }

        private void divideVertical(int left, int right, int top, int bottom)
        {
            int divide = left + 2 + rand.Next(0, (right - left - 1) / 2) * 2;
            
            for (int i = top; i < bottom; i++)
            {
                Maze[i][divide] = MAZE_WALL;
            }

            int clearSpace = top + rand.Next(0, (bottom - top) / 2) * 2 + 1;

            Maze[clearSpace][divide] = MAZE_PATH;

            makeMaze(left, divide, top, bottom);
            makeMaze(divide, right, top, bottom);
        }

        private void divideHorizontal(int left, int right, int top, int bottom)
        {
            int divide = top + 2 + rand.Next(0, (bottom - top - 1) / 2) * 2;
            if (divide % 2 == 1)
                divide++;
            
            for (int i = left; i < right; i++)
            {
                Maze[divide][i] = MAZE_WALL;
            }
            
            int clearSpace = left + rand.Next(0, (right - left) / 2) * 2 + 1;

            Maze[divide][clearSpace] = MAZE_PATH;
            
            makeMaze(left, right, top, divide);
            makeMaze(left, right, divide, bottom);
        }

        private void makeOpenings()
        {
            Maze[1][0] = MAZE_PATH;
            Maze[rows - 2][cols - 1] = MAZE_PATH;
        }
        
        
        public static string nasoka(Node first, Node second)
        {
            if (second.X == first.X && second.Y == first.Y - 1)
                return "left";
            if (second.X == first.X && second.Y == first.Y + 1)
                return "right";
            if (second.X == first.X - 1 && second.Y == first.Y)
                return "up";
            if (second.X == first.X + 1 && second.Y == first.Y)
                return "down";
            return "not neighbours";
        }

        public static string GetDirections(IEnumerable<INode> path)
        {
            int brojNaDvizenja = 1;
            String nasoka1 = null;
            String nasoka2 = "";
            Node start=null;
            Node next=null;
           
            IEnumerator enumerator = path.GetEnumerator();
            if(enumerator.MoveNext())
                 start = enumerator.Current as Node;
            if(enumerator.MoveNext())
                 next = enumerator.Current as Node;
            if (start == null || next == null)
                return "Sorry, can't help you";
            nasoka1 = nasoka(start, next);

            
            Node previous = next;
            while ( enumerator.MoveNext())
            {
                next = enumerator.Current as Node;
                if (nasoka1 == nasoka(previous, next))
                    brojNaDvizenja++;
                else
                {
                    nasoka2 = null;
                    break;
                }
                previous = next;
            }

            if(nasoka2==null)
                nasoka2 = "and then turn "+nasoka(previous, next);
            return String.Format("Go {0} {1} blocs {2}", nasoka1, brojNaDvizenja, nasoka2);
        }
    }
}