using GridLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConwaysGameOfLife
{
    public class UserInput
    {
        public static void GainUserInput()   // Gain simulation size for creation of arrays
        {
            Console.Write("Welcome to Conway's Game of Life!\n\nPlease enter the height: ");
            string input = Console.ReadLine();
            try
            {
                Grid.heightInput = Int32.Parse(input) + 2; // + 2 to add a buffer around the array preventing out of bounds error.
            }
            catch
            {
                Console.WriteLine("Unable to process input");
            }

            Console.Write("Please enter the width: ");
            input = Console.ReadLine();
            try
            {
                Grid.widthInput = Int32.Parse(input) + 2; // + 2 to add a buffer around the array preventing out of bounds error.
            }
            catch
            {
                Console.WriteLine("Unable to process input");
            }
        }
    }
}
