using GridLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    class DisplayGrid
    {
        int GenerationCounter = 1;
        public void DisplayNewGrid(int[,] input)          //  Displays existing grids
        {
            Console.WriteLine($"\nGeneration: {GenerationCounter}\n");
            GenerationCounter++;

            for (int y = 1; y < Grid.heightInput - 1; y++)
            {
                for (int x = 1; x < Grid.widthInput - 1; x++)
                {
                    if (input[y, x] == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n----------------------------------------");       // Create spacing between generations  
        }
    }
}
