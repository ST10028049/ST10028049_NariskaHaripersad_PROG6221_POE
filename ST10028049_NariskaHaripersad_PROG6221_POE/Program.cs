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
            Console.ForegroundColor = ConsoleColor.Blue; // changes the text colour to blue
            Console.WriteLine("Ingredients:");
            Console.ResetColor(); // changes the text colour back to its default colour 

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("- " + ingredientQuantities[i] + " " + (ingredientUnits[i]).ToLower() + " " + ingredientNames[i]);
                Console.ResetColor();
            }

        }

        public void scaleIngredients(int scale) // a method that scales the ingredients 
        {
            
            isInputValid = false; // to validate the user's input 
            while (!isInputValid) // while loop will keep running until the user's input is valid - the input will only be valid if the user enters 1, 2 or 3
            {
                try
                {
                    if (scale == 1) 
                    {
                        for (int i = 0; i < numOfIngredients; i++)
                        {
                            ingredientQuantities[i] = (ingredientQuantities[i] * 0.5); 
                        }
                        Console.WriteLine("The recipe has been successfully scaled.");
                        isInputValid = true;
                    }
                    else
                    {
                        if (scale == 2)
                        {
                            for (int i = 0; i < numOfIngredients; i++)
                            {
                                ingredientQuantities[i] = (ingredientQuantities[i] * 2);
                            }
                            Console.WriteLine("The recipe has been successfully scaled.");
                            isInputValid = true;
                        }
                        else
                        {
                            if (scale == 3)
                            {
                                for (int i = 0; i < numOfIngredients; i++)
                                {
                                    ingredientQuantities[i] = (ingredientQuantities[i] * 3);
                                }
                                Console.WriteLine("The recipe has been successfully scaled.");
                                isInputValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid option!");
                            }
                        }
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Input is invalid!");
                }
            }
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
