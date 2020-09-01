using GridLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    class ProcessGrid // Wasn't sure if corner neighbors needed to be included (grid [y - 1, x -1] for example). Decided input looked closer to example without them.
    {
        public int[,] DifferentGrid;

        public void ProcessNewGrid(int[,] input)  // Runs grid through logic and assigns new results to a new array. This allows program to fully run through array before changing values.
        {
            DifferentGrid = new int[Grid.heightInput, Grid.widthInput];
            for (int y = 1; y < Grid.heightInput - 1; y++)
            {
                for (int x = 1; x < Grid.widthInput - 1; x++)
                {
                    if (input[y, x] == 1)             // If cell is alive
                    {
                        if (input[y - 1, x] +
                            input[y, x - 1] +
                            input[y, x + 1] +
                            input[y + 1, x] < 2)
                        {
                            DifferentGrid[y, x] = 0;   // Live cell with fewer than two neighbors -- dies                        
                        }
                        else if (input[y - 1, x] +
                            input[y, x - 1] +
                            input[y, x + 1] +
                            input[y + 1, x] == 2 ||   // Live cell with two neighbors -- lives

                            input[y - 1, x] +
                            input[y, x - 1] +
                            input[y, x + 1] +
                            input[y + 1, x] == 3)
                        {
                            DifferentGrid[y, x] = 1;     // Live cell with three neighbors -- lives                       
                        }
                        else
                        {
                            DifferentGrid[y, x] = 0;    // Live cell with more than 3 neighbors -- dies                        
                        }
                    }
                    else                                // If cell is dead
                    {
                        if (input[y - 1, x] +
                            input[y, x - 1] +
                            input[y, x + 1] +
                            input[y + 1, x] == 3)
                        {
                            DifferentGrid[y, x] = 1;    // Dead cell with exactly three neighbors -- lives                        
                        }
                        else
                        {
                            DifferentGrid[y, x] = 0;    // Dead cell without exactly three neighbors -- dies
                        }
                    }
                }
            }
        }
    }
}
