using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            if (scale == 1)
            {

                for (int i = 0; i < numOfIngredients; i++) 
                {
                    ingredientQuantities[i] = (ingredientQuantities[i] / 0.5); // if the ingredient was scaled by half it will be divided by half to reset it back to its original value 
                }
                Console.WriteLine("The recipe has been successfully reset."); // output message
            }
            else
            {
                if (scale == 2)
                {
                    for (int i = 0; i < numOfIngredients; i++) 
                    {
                        ingredientQuantities[i] = (ingredientQuantities[i] / 2); // if the ingredient was scaled by double it will be divided by 2 to reset it back to its original value 
                    }
                    Console.WriteLine("The recipe has been successfully reset."); // output message 
                }

                else
                {
                    if (scale == 3)
                    {
                        for (int i = 0; i < numOfIngredients; i++)
                        {
                            ingredientQuantities[i] = (ingredientQuantities[i] / 3); // if the ingredient was scaled by triple it will be divided by 3 to reset it back to its original value 
                        }
                        Console.WriteLine("The recipe has been successfully reset."); // output message 
                    }
                }
            }
        }
    }

    class Step // contains the methods that will perform functions on the recipe steps 
    {
        private string[] steps;
        private int numOfSteps;
        private string description;
        private bool isInputValid;
        public void getSteps()
        {
            isInputValid = false;
            while (!isInputValid)
            {
                try
                {
                    Console.WriteLine("Enter the number of steps: "); // prompts the user to enter the number of steps that the recipe will contain 
                    numOfSteps = Convert.ToInt32(Console.ReadLine());
                    isInputValid = true; 
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Input is invalid!");
                }
            }

            Console.WriteLine("\r\n");

            steps = new string[numOfSteps];

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.WriteLine("Enter description: ");
                description = Console.ReadLine();
                steps[i] = description;
                Console.WriteLine("\r\n");
            }
        }

        public void printSteps() // a method that displays the recipe steps
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Steps:");
            Console.ResetColor();

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // changes the text colour to yellow 
                Console.WriteLine((i + 1) + ". " + steps[i]); // the step description is numbered and displayed 
                Console.ResetColor(); 
            }
        }
    }

    class RecipeApplication
    {
        Ingredient ingredient = new Ingredient();
        Step step = new Step();
        public void runApplication()
        {
            Console.WriteLine("Welcome!");
            captureRecipe();
        }

        public void runMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Display recipe");
            Console.WriteLine("2. Scale recipe");
            Console.WriteLine("3. Clear data");
            Console.WriteLine("4. Exit application");
            Console.WriteLine("Enter the number of the action you would like to perform:");
            int option = Convert.ToInt32(Console.ReadLine());
            while (option != 1 & option != 2 & option != 3 & option != 4)
            {
                Console.WriteLine("Invalid option!");
                Console.WriteLine("\r\n");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Display recipe");
                Console.WriteLine("2. Scale recipe");
                Console.WriteLine("3. Clear data");
                Console.WriteLine("4. Exit application");
                Console.WriteLine("Enter the number of the action you would like to perform:");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1 || option == 2 || option == 3)
            {
                if (option == 1)
                {
                    Console.WriteLine("\r\n");
                    ingredient.printIngredients();
                    step.printSteps();
                    Console.WriteLine("\r\n");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Display recipe");
                    Console.WriteLine("2. Scale recipe");
                    Console.WriteLine("3. Clear data");
                    Console.WriteLine("4. Exit application");
                    Console.WriteLine("Enter the number of the action you would like to perform:");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    if (option == 2)
                    {
                        Console.WriteLine("Scale the recipe by half, double or triple. Enter 1 for half, 2 for double or 3 for triple.");
                        int scaleOption = Convert.ToInt32(Console.ReadLine());
                        if (scaleOption == 1)
                        {
                            ingredient.scaleIngredients(scaleOption);
                            runScaleRecipeMenu(scaleOption);
                        }
                        else
                        {
                            if (scaleOption == 2)
                            {
                                ingredient.scaleIngredients(scaleOption);
                                runScaleRecipeMenu(scaleOption);
                            }
                            else
                            {
                                if (scaleOption == 3)
                                {
                                    ingredient.scaleIngredients(scaleOption);
                                    runScaleRecipeMenu(scaleOption);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option!");
                                    runMenu();
                                }
                            }
                        }
                    }

                    else
                    {
                        if (option == 3)
                        {
                            Console.WriteLine("Confirm that you would like to clear all the data and enter a new recipe? Enter 'y' to confirm or 'n' to cancel action.");
                            char confirmClear = Convert.ToChar(Console.ReadLine());
                            while (confirmClear != 'y' && confirmClear != 'n')
                            {
                                Console.WriteLine("Invalid character! Enter 'y' to confirm or 'n' to cancel action.");
                                confirmClear = Convert.ToChar(Console.ReadLine());
                            }
                            if (confirmClear == 'y')
                            {
                                Console.Clear();
                                captureRecipe();
                            }
                            else
                            {
                                runMenu();
                            }

                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
        public void captureRecipe()
        {
            Console.WriteLine("You are required to enter the details for a single recipe.");
            Console.WriteLine("\r\n");
            ingredient.getIngredients();
            step.getSteps();
            Console.WriteLine("The recipe details have been successfully captured.");
            Console.WriteLine("\r\n");
            runMenu();
        }

        public void runScaleRecipeMenu(int scaleOption)
        {
            Console.WriteLine("Would you like to view the scaled recipe? Enter 'y' for yes or 'n' for no");
            char yesNo = Convert.ToChar(Console.ReadLine());
            if (yesNo == 'y')
            {
                Console.WriteLine("\r\n");
                ingredient.printIngredients();
                step.printSteps();
                Console.WriteLine("\r\n");
                Console.WriteLine("Would you like to reset recipe? Enter 'y' for yes or 'n' for no.");
                yesNo = Convert.ToChar(Console.ReadLine());
                if (yesNo == 'y')
                {
                    ingredient.resetIngredients(scaleOption);
                    Console.WriteLine("Would you like to view the reset recipe? Enter 'y' for yes or 'n' for no.");
                    yesNo = Convert.ToChar(Console.ReadLine());
                    if (yesNo == 'y')
                    {
                        Console.WriteLine("\r\n");
                        ingredient.printIngredients();
                        step.printSteps();
                        Console.WriteLine("\r\n");
                        runMenu();
                    }
                    else
                    {
                        runMenu();
                    }
                }
                else
                {
                    if (yesNo == 'n')
                    {
                        runMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid!");
                        runMenu();
                    }
                }
            }

            else
            {
                if (yesNo == 'n')
                {
                    runMenu();
                }
                else
                {
                    Console.WriteLine("Invalid!");
                    runMenu();
                }
            }
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            RecipeApplication app = new RecipeApplication();
            app.runApplication();
        }
    }
}
