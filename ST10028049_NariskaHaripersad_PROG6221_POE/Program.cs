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
            isInputValid = false; // to validate the user's input
            while (!isInputValid)  // while loop will keep running until the user's input is valid - the input will only be valid if the user enters an integer 
            {
                try
                {
                    Console.WriteLine("Enter the number of ingredients: "); // prompts the user to enter the number of ingredients in the recipe
                    numOfIngredients = Convert.ToInt32(Console.ReadLine()); // reads the user's input and stores it if it's an integer
                    isInputValid = true; // if the user inputted an integer then the input is valid and it will exit out of the while loop 
                }
                catch (FormatException) // if the user did not input an integer
                {
                    Console.WriteLine("Input is invalid!");
                }
            }

            Console.WriteLine("\r\n"); // skip a line in the output 

            // the sizes of the arrays are declared
            ingredientNames = new string[numOfIngredients]; 
            ingredientQuantities = new double[numOfIngredients];
            ingredientUnits = new string[numOfIngredients];

            for (int i = 0; i < numOfIngredients; i++) // for each ingredient the user will be prompted to enter the ingredient name, ingredient quantity and unit of measurement
            {
                Console.WriteLine("Enter name: "); // prompts the user to enter the name of the ingredient
                name = Console.ReadLine(); // reads the user's input and stores it as a string 
                ingredientNames[i] = name; // the ingredient name the user entered is stored in an array 

                isInputValid = false; // to validate the user's input
                while (!isInputValid) // while loop will keep running until the user's input is valid - the input will only be valid if the user enters a double 
                {
                    try
                    {
                        Console.WriteLine("Enter quantity: "); // prompts the user to enter the ingredient quantity 
                        quantity = Convert.ToDouble(Console.ReadLine()); // reads the user's input and stores it as a double 
                        ingredientQuantities[i] = quantity; // the ingredient quantity the user entered is stored in an array 
                        isInputValid = true; // if the user inputted a double then the input is valid and it will exit out of the while loop
                    }
                    catch (FormatException) // if the user did not input a double 
                    {
                        Console.WriteLine("Input is invalid!"); 
                    }
                }

                Console.WriteLine("Enter unit of measurement: "); // prompts the user to enter the unit of measurement 
                unit = Console.ReadLine(); // reads the user's input and stores it as a string
                ingredientUnits[i] = unit; // the unit of measurement the user entered is stored in an array 

                Console.WriteLine("\r\n"); // skip a line in the output 
            }
        }

        public void printIngredients() // a method that displays the ingredient details 
        {
            Console.ForegroundColor = ConsoleColor.Blue; // changes the text colour to blue
            Console.WriteLine("Ingredients:");
            Console.ResetColor(); // changes the text colour back to its default colour 

            for (int i = 0; i < numOfIngredients; i++) // for each ingredient, the ingredient name, quantity and unit of measurement will be displayed 
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // changes the text colour to blue
                Console.WriteLine("- " + ingredientQuantities[i] + " " + (ingredientUnits[i]).ToLower() + " " + ingredientNames[i]); 
                Console.ResetColor(); // changes the text colour back to its default colour
            }

        }

        public void scaleIngredients(int scale) // a method that scales the ingredients 
        {
            
            isInputValid = false; // to validate the user's input 
            while (!isInputValid) // while loop will keep running until the user's input is valid - the input will only be valid if the user enters an integer and if the integer is 1, 2 or 3
            {
                try
                {
                    if (scale == 1)
                    {
                        for (int i = 0; i < numOfIngredients; i++) // for each ingredient, it's quantity will be halved 
                        {
                            ingredientQuantities[i] = (ingredientQuantities[i] * 0.5); 
                        }
                        Console.WriteLine("The recipe has been successfully scaled.");
                        isInputValid = true; // if the user inputted an integer and the integer is 1 then the input is valid and it will exit out of the while loop
                    }
                    else
                    {
                        if (scale == 2)
                        {
                            for (int i = 0; i < numOfIngredients; i++) // for each ingredient, it's quantity will be doubled 
                            {
                                ingredientQuantities[i] = (ingredientQuantities[i] * 2);
                            }
                            Console.WriteLine("The recipe has been successfully scaled.");
                            isInputValid = true; // if the user inputted an integer and the integer is 2 then the input is valid and it will exit out of the while loop
                        }
                        else
                        {
                            if (scale == 3)
                            {
                                for (int i = 0; i < numOfIngredients; i++) // for each ingredient, it's quantity will be tripled 
                                {
                                    ingredientQuantities[i] = (ingredientQuantities[i] * 3);
                                }
                                Console.WriteLine("The recipe has been successfully scaled.");
                                isInputValid = true; // if the user inputted an integer and the integer is 3 then the input is valid and it will exit out of the while loop
                            }
                            else
                            {
                                // if the user entered an integer but it was not 1,2 or 3 
                                Console.WriteLine("Invalid option!"); 
                            }
                        }
                    }

                }
                catch (FormatException) // if the user did not enter an integer 
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
                    ingredientQuantities[i] = (ingredientQuantities[i] / 0.5); // the quantity was scaled by half so it will be divided by half to reset it back to its original value 
                }
                Console.WriteLine("The recipe has been successfully reset."); // output message
            }
            else
            {
                if (scale == 2)
                {
                    for (int i = 0; i < numOfIngredients; i++) 
                    {
                        ingredientQuantities[i] = (ingredientQuantities[i] / 2); // the quantity was scaled by double so it will be divided by 2 to reset it back to its original value 
                    }
                    Console.WriteLine("The recipe has been successfully reset."); // output message 
                }

                else
                {
                    if (scale == 3)
                    {
                        for (int i = 0; i < numOfIngredients; i++)
                        {
                            ingredientQuantities[i] = (ingredientQuantities[i] / 3); // the quantity was scaled by triple so it will be divided by 3 to reset it back to its original value 
                        }
                        Console.WriteLine("The recipe has been successfully reset."); // output message 
                    }
                }
            }
        }
    }

    class Step // contains the methods that will perform functions on the recipe steps 
    {
        // variable declarations 
        private string[] steps; // an array that stores the recipe steps 
        private int numOfSteps; // stores the number of steps 
        private string description; // the description of the step 
        private bool isInputValid; // used to determine whether an inputted value is valid or not
        
        public void getSteps() // a method that allows the user to input details about the recipe steps and stores it in memory
        {
            isInputValid = false;  // to validate the user's input
            while (!isInputValid)  // while loop will keep running until the user's input is valid - the input will only be valid if the user enters an integer 
            {
                try
                {
                    Console.WriteLine("Enter the number of steps: "); // prompts the user to enter the number of steps that the recipe will contain 
                    numOfSteps = Convert.ToInt32(Console.ReadLine()); // reads the user's input and stores it if it's an integer
                    isInputValid = true; // if the user inputted an integer then the input is valid and it will exit out of the while loop 
                }
                catch (FormatException) // if the user did not enter an integer 
                {
                    Console.WriteLine("Input is invalid!");
                }
            }

            Console.WriteLine("\r\n"); // skip a line in the output 

            steps = new string[numOfSteps]; // the size of the array is declared 

            for (int i = 0; i < numOfSteps; i++) // each step needs a description 
            {
                Console.WriteLine("Enter description: "); // prompts the user to enter a description for a step
                description = Console.ReadLine(); // stores the description as a string 
                steps[i] = description; // the description is stored in an array 
                Console.WriteLine("\r\n"); // skip a line in the output
            }
        }

        public void printSteps() // a method that displays the recipe steps
        {
            Console.ForegroundColor = ConsoleColor.Blue; // changes the text colour to yellow 
            Console.WriteLine("Steps:"); 
            Console.ResetColor();

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // changes the text colour to yellow 
                Console.WriteLine((i + 1) + ". " + steps[i]); // the step description is numbered and displayed 
                Console.ResetColor(); // changes the text colour back to its default colour
            }
        }
    }

    class RecipeApplication // contains the methods that allow the recipe application to run as a whole
    {
        Ingredient ingredient = new Ingredient(); // declare object to use methods from the Ingredient class 
        Step step = new Step(); // declare object to use methods from the Step class 
     
        public void runApplication() // runs the entire application by calling a method that calls other methods in the class and from other classes 
        {
            Console.WriteLine("Welcome!"); 
            captureRecipe(); // the recipe details are captured as soon as the application is run 
        }

        public void runMenu() // displays the menu options and allows the user to input their menu option 
        {
            // the menu
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Display recipe");
            Console.WriteLine("2. Scale recipe");
            Console.WriteLine("3. Clear data");
            Console.WriteLine("4. Exit application");
            Console.WriteLine("Enter the number of the action you would like to perform:"); // prompts the user for input 
            int option = Convert.ToInt32(Console.ReadLine());
            while (option != 1 & option != 2 & option != 3 & option != 4) // while loop will keep running until the user enters a valid option from the menu 
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
                if (option == 1) // prints the recipe and then displays the menu
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
                    if (option == 2) // scales the recipe and then displays the menu 
                    {
                        Console.WriteLine("Scale the recipe by half, double or triple. Enter 1 for half, 2 for double or 3 for triple.");
                        int scaleOption = Convert.ToInt32(Console.ReadLine());
                        if (scaleOption == 1) // halves the recipe quantities 
                        {
                            ingredient.scaleIngredients(scaleOption); // recipe is scaled 
                            runScaleRecipeMenu(scaleOption); // the menu that runs after the recipe is scaled
                        }
                        else
                        {
                            if (scaleOption == 2) // doubles the recipe quantities 
                            {
                                ingredient.scaleIngredients(scaleOption); // recipe is scaled
                                runScaleRecipeMenu(scaleOption); // the menu that runs after the recipe is scaled
                            }
                            else
                            {
                                if (scaleOption == 3) // triples the recipe quantities
                                {
                                    ingredient.scaleIngredients(scaleOption); // recipe is scaled
                                    runScaleRecipeMenu(scaleOption); // the menu that runs after the recipe is scaled
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
                        if (option == 3) // clears the data 
                        {
                            // asks the user to confirm if they want to clear the data 
                            Console.WriteLine("Confirm that you would like to clear all the data and enter a new recipe? Enter 'y' to confirm or 'n' to cancel action.");
                            char confirmClear = Convert.ToChar(Console.ReadLine()); 
                            while (confirmClear != 'y' && confirmClear != 'n') // the while loop will keep running until the user enters a valid character - a valid character is 'y' or 'n'
                            {
                                Console.WriteLine("Invalid character! Enter 'y' to confirm or 'n' to cancel action.");
                                confirmClear = Convert.ToChar(Console.ReadLine());
                            }
                            if (confirmClear == 'y') // if the user confirms that they want the data to be cleared 
                            {
                                Console.Clear(); // console is cleared 
                                captureRecipe(); // the method to capture recipe details is run again to capture a new recipe 
                            }
                            else // if the user does not want to clear the data 
                            {
                                runMenu(); // the menu is run again 
                            }

                        }
                        else // if the user entered 4 as their menu option 
                        {
                            Environment.Exit(0); // exit the application 
                        }
                    }
                }
            }
        }
        
        // method to capture a recipe 
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

        // method that runs a menu when a recipe is scaled 
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
