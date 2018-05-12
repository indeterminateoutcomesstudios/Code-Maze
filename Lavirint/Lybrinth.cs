using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavirint
{
    class Lybrinth
    {
           Random rand = new Random();
            public int Dimensions { get; set; }
            public bool[][] Maze { get; set; }
            public int[] Positon { get; set; }
            public int[] Start { get; set; }
            public int[] Finish { get; set; }
            public string mazeString { get; set; }

            public Lybrinth(int dimensions)
            {
                Dimensions = dimensions;
                Start = new int[2] { dimensions - 2, 0 };
                Finish = new int[2] { 1, dimensions - 1 };
                Maze = MazeGenerator(width: dimensions, height: dimensions);
                mazeString = ArrayToString(Maze, "   ");


            }
            public bool[][] MazeGenerator(int width = 10, int height = 10, decimal complexity = 0.75m, decimal density = 0.75m)
            {
                int shape1 = (int)Math.Floor((decimal)height / 2) * 2 + 1;
                int shape2 = (int)Math.Floor((decimal)width / 2) * 2 + 1;
                complexity = (int)(complexity * (5 * (shape1 + shape2)));
                density = (int)(density * ((shape1 / 2) * (shape2 / 2)));
                bool[][] z = new bool[shape1][];
                for (int i = 0; i < shape1; i++)
                {
                    z[i] = new bool[shape2]; // Create inner array
                }

                for (int i = 0; i < shape1; i++)
                {
                    for (int j = 0; j < shape2; j++)
                        z[i][j] = true;
                }

                for (int i = 0; i < shape2; i++)
                {
                    z[0][i] = false;
                    z[shape1 - 1][i] = false;
                }
                for (int i = 0; i < shape1 - 2; i++)
                {
                    z[i][0] = false;
                    z[shape1 - 1 - i][shape2 - 1] = false;
                }
                for (int i = 0; i < density; i++)
                {

                    int x = rand.Next(0, shape2 / 2) * 2;
                    int y = rand.Next(0, shape1 / 2) * 2;
                    z[y][x] = false;

                    for (int j = 0; j < complexity; j++)
                    {
                        List<int[]> neighbours = new List<int[]>();

                        if (x > 1)
                            neighbours.Add(new int[] { y, x - 2 });
                        if (x < shape2 - 2)
                            neighbours.Add(new int[] { y, x + 2 });
                        if (y > 1)
                            neighbours.Add(new int[] { y - 2, x });

                        if (y < shape1 - 2)
                            neighbours.Add(new int[] { y + 2, x });

                        if (neighbours.Count > 0)
                        {
                            int br = rand.Next(0, neighbours.Count - 1);
                            int y_ = neighbours[br][0];
                            int x_ = neighbours[br][1];
                            if (z[y_][x_] == true)
                            {
                                z[y_][x_] = false;
                                z[y_ + (y - y_) / 2][x_ + (x - x_) / 2] = false;
                                x = x_;
                                y = y_;
                            }
                        }

                    }

                }
                return z;
            }

        public static string ArrayToString(IList array, string delimeter)
        {
            string outputString = "";

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is IList)
                {
                    //Recursively convert nested arrays to string
                    outputString += ArrayToString((IList)array[i], delimeter);
                }
                else
                {
                    outputString += array[i];
                }
                if (i != array.Count - 1)
                    outputString += delimeter;
            }
            return outputString;
        }
    }
}