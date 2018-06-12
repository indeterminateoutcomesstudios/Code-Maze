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
            makeMaze();
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

            Random rand = new Random(); //two different random number generators
            Random rand2 = new Random();//just in case

            //a random location for the entrance and exit
            int entrance_row = rand.Next(0, act_rows - 1) * 2 + 1;
            int exit_row = rand2.Next(0, act_rows - 1) * 2 + 1;

            //clear the location
            Maze[entrance_row][0] = MAZE_PATH;
            Maze[exit_row][cols - 1] = MAZE_PATH;

        }


        public static string ArrayToString(IList array, string delimeter)
        {
            string outputString = " ";

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is IList)
                {
                    //Recursively convert nested arrays to string
                    outputString += ArrayToString((IList)array[i], delimeter);
                }
                else
                {
                    outputString += (bool)array[i] ? "1" : "0";
                }
                if (i != array.Count - 1)
                    outputString += delimeter;
                else
                    outputString += "\n";
            }
            return outputString;
        }
    }
}