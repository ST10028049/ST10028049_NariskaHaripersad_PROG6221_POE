using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10028049_NariskaHaripersad_PROG6221_POE
{
    class Ingredient // contains the methods that will perform functions on the recipe ingredients 
    {
        // variable declarations 
        private string[] ingredientNames; // an array that stores the ingredient names 
        private double[] ingredientQuantities; //an array that stores the ingredient quantities 
        private string[] ingredientUnits; //an array that stores the unit of measurements
        private int numOfIngredients; // stores the number of ingredients
        private string name; // name of the ingredient 
        private double quantity; // the quantity of the ingredient 
        private string unit; // the unit of measurement 
        private bool isInputValid; // used to determine whether an inputted value is valid or not

        public void getIngredients() // a method that allows the user to input details about the recipe ingredients and stores it in memory
        {
            isInputValid = false;
            while (!isInputValid)
            {
                try
                {
                    Console.WriteLine("Enter the number of ingredients: ");
                    numOfIngredients = Convert.ToInt32(Console.ReadLine());

                    isInputValid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input is invalid!");
                }
            }

            Console.WriteLine("\r\n");

            ingredientNames = new string[numOfIngredients];
            ingredientQuantities = new double[numOfIngredients];
            ingredientUnits = new string[numOfIngredients];

            for (int i = 0; i < numOfIngredients; i++)
            {

                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                ingredientNames[i] = name;

                isInputValid = false;
                while (!isInputValid)
                {
                    try
                    {
                        Console.WriteLine("Enter quantity: ");
                        quantity = Convert.ToDouble(Console.ReadLine());
                        ingredientQuantities[i] = quantity;
                        isInputValid = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input is invalid!");
                    }
                }

                Console.WriteLine("Enter unit of measurement: ");
                unit = Console.ReadLine();
                ingredientUnits[i] = unit;

                Console.WriteLine("\r\n");
            }
        }

        public void printIngredients() // a method that displays the ingredient details 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingredients:");
            Console.ResetColor();

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("- " + ingredientQuantities[i] + " " + (ingredientUnits[i]).ToLower() + " " + ingredientNames[i]);
                Console.ResetColor();
            }

        }

        public void scaleIngredients(int scale) // a method that scales the ingredients 
        {

        }

        public void resetIngredients(int scale) // a method that resets the recipe back to its original values
        {
            
        }

    }
     
        internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
