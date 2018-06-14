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
            Goal = MazeofNodes[rows - 2][cols - 2];
            //Start = MazeofNodes[1][1];

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
                    Random rand = new Random();
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
            Random rand = new Random();

            //find a random point to divide at
            //must be even to draw a wall there
            int divide = left + 2 + rand.Next(0, (right - left - 1) / 2) * 2;

            //draw a line at the halfway point
            for (int i = top; i < bottom; i++)
            {
                Maze[i][divide] = MAZE_WALL;
            }

            //get a random odd integer between top and bottom and clear it
            int clearSpace = top + rand.Next(0, (bottom - top) / 2) * 2 + 1;

            Maze[clearSpace][divide] = MAZE_PATH;

            makeMaze(left, divide, top, bottom);
            makeMaze(divide, right, top, bottom);
        }

        private void divideHorizontal(int left, int right, int top, int bottom)
        {
            Random rand = new Random();

            //find a random point to divide at
            //must be even to draw a wall there
            int divide = top + 2 + rand.Next(0, (bottom - top - 1) / 2) * 2;
            if (divide % 2 == 1)
                divide++;

            //draw a line at the halfway point
            for (int i = left; i < right; i++)
            {
                Maze[divide][i] = MAZE_WALL;
            }

            //get a random odd integer between left and right and clear it
            int clearSpace = left + rand.Next(0, (right - left) / 2) * 2 + 1;

            Maze[divide][clearSpace] = MAZE_PATH;

            //recur for both parts of the newly split section
            makeMaze(left, right, top, divide);
            makeMaze(left, right, divide, bottom);
        }

        private void makeOpenings()
        {

            /*Random rand = new Random(); //two different random number generators
            Random rand2 = new Random();//just in case

            //a random location for the entrance and exit
            int entrance_row = rand.Next(0, act_rows - 1) * 2 + 1;
            int exit_row = rand2.Next(0, act_rows - 1) * 2 + 1;

            //clear the location
            Maze[entrance_row][0] = MAZE_PATH;
            Maze[exit_row][cols - 1] = MAZE_PATH;*/
            Maze[1][0] = MAZE_PATH;
            Maze[rows - 2][cols - 1] = MAZE_PATH;

        }


        public static string ArrayToString(IEnumerable<INode> path, string delimeter)
        {
            string outputString = "";
            IEnumerator enumerator = path.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Node node = enumerator.Current as Node;
                outputString += node.ToString() + " ";
            }
            return outputString;
        }

        public string Print(IEnumerable<INode> path)
        {
            var output = "";
            for (var i = 0; i < cols; i++)
            {
                for (var j = 0; j < rows; j++)
                {
                    output += MazeofNodes[i][j].Print(Start, Goal, path);
                }
                output += "\n";
            }
            return output;
        }

        public static string GetDirections(IEnumerable<INode> path)
        {

            string outputString = "";
            IEnumerator enumerator = null;
             enumerator = path.GetEnumerator();
            enumerator.MoveNext();
            Node current = enumerator.Current as Node;
            int x = current.X;
            int y = current.Y;
            int brojNaDvizenja = 1;
            String nasoka1 = null;
            String nasoka2 = null;
            enumerator.MoveNext();
            Node next = enumerator.Current as Node;
            bool izlezi = true;
            if (next.X == x && next.Y == y - 1)
                nasoka1 = "left";
            if (next.X == x && next.Y == y + 1)
                nasoka1 = "right";
            if (next.X == x - 1 && next.Y == y)
                nasoka1 = "up";
            if (next.X == x + 1 && next.Y == y)
                nasoka1 = "down";
            Node node = current;
            Node previous = current;
            while (izlezi)
            {
                previous = node;
                enumerator.MoveNext();
                node = enumerator.Current as Node;
                if (nasoka1 == "left")
                {
                    if (node.X == x && node.Y == y - 1 - brojNaDvizenja)
                        brojNaDvizenja++;
                    else
                        izlezi = false;
                }
                if (nasoka1 == "right")
                {
                    if (node.X == x && node.Y == y + 1 + brojNaDvizenja)
                        brojNaDvizenja++;
                    else
                        izlezi = false;
                }
                if (nasoka1 == "up")
                {
                    if (node.X == x - 1 - brojNaDvizenja && node.Y == y)
                        brojNaDvizenja++;
                    else
                        izlezi = false;
                }
                if (nasoka1 == "down")
                {
                    if (node.X == x + 1 + brojNaDvizenja && node.Y == y)
                        brojNaDvizenja++;
                    else
                        izlezi = false;
                }
            }


            if (node.X == previous.X && node.Y == previous.Y - 1)
                nasoka2 = "left";
            if (node.X == previous.X && node.Y == previous.Y + 1)
                nasoka2 = "right";
            if (node.X == previous.X - 1 && node.Y == previous.Y)
                nasoka2 = "up";
            if (node.X == previous.X + 1 && node.Y == previous.Y)
                nasoka2 = "down";

            return String.Format("Go {0} {1} steps and then turn {2}", nasoka1, brojNaDvizenja, nasoka2);
        }
    }
}