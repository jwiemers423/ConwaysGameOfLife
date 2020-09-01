using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateGrid newGrid = new CreateGrid();
            DisplayGrid DG = new DisplayGrid();
            ProcessGrid PG = new ProcessGrid();
            UserInput.GainUserInput();
            newGrid.CreateNewGrid();
            DG.DisplayNewGrid(newGrid.grid);
            PG.ProcessNewGrid(newGrid.grid);

            for (int i = 0; i < 9; i++) //Determins how many times simulation is run
            {
                DG.DisplayNewGrid(PG.DifferentGrid);
                PG.ProcessNewGrid(PG.DifferentGrid);
            }
        }
    }
}
