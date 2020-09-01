using GridLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    public class CreateGrid
    {
        private Random rand = new Random();

        public int[,] grid;

        public void CreateNewGrid()  // Create the first grid itself and assigns random number value for first array.
        {
            grid = new int[Grid.heightInput, Grid.widthInput];

            for (int y = 1; y < Grid.heightInput - 1; y++)
            {
                for (int x = 1; x < Grid.widthInput - 1; x++)
                {
                    grid[y, x] = rand.Next(0, 2);
                }
            }
        }
    }
}
