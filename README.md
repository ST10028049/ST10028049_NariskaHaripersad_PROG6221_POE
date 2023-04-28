# Recipe Application 
This is a command line application designed using C# and Visual Studio. This application is designed to capture and store details for a recipe and perform various functions on the recipe.
## Features 
- A user can enter the details of a recipe. They can enter details about the ingredients such as the number of ingredients used in the recipe, the ingredient name, the quantity of the ingredient and the unit of measurement of the ingredient and the user can enter details about the recipe steps such as the number of steps in the recipe and a description of each step. 
- The user can view the full recipe that they entered. 
- The user can scale the recipe. The ingredient quantities can be scaled by half, double or triple. 
- The user can reset the recipe back to its original values after scaling the recipe. 
- The user can clear all the data and enter a new recipe. 
## Running The Application 
- As soon as a user starts running the application, they will be required to enter the details for a recipe. 
- The user will have to input the number of ingredients. 
- Depending on the number of ingredients, the user will be asked to input the ingredient name, the ingredient quantity and unit of measurement for each ingredient. 
- Once the user has entered the ingredients details, they will be prompted to enter the number of steps in the recipe. 
- Depending on the number of steps, the user will be asked to input a description for each step in the recipe. 
- Once the user has inputted the step descriptions, a menu with 4 options will appear where the user will have to input the number that corresponds with the option they they want to choose. 
- If the user enters 1, the recipe details that they entered will be displayed. The headings of the recipe such as 'Ingredients' and 'Steps' will be displayed in blue. The ingredient details will be displayed under the heading 'Ingredients' in a list and in light yellow. The description of each steps will be numbered by the order that they were inputted by the user and will be displayed under the heading 'Steps' in light yellow. 
- Once recipe details have been displayed, the menu with 4 options will display again. The menu will keep being displayed until the user chooses to exit the application. 
- If the user enters 2 on the menu, the recipe will be scaled. The user will be asked to scale the recipe by half, double or triple. If the user enters 1, the recipe quantities will be halved, if the user enters 2, the recipe quantities will be doubled and if the user enters 3, the recipe quantities will be tripled. The user will be asked if they want to view the scaled recipe. The user will have to enter 'y' for 'yes' or 'n' for 'no'. If the user enters 'yes' the scaled recipe will be printed. The user will then be asked if they want to reset the recipe back to its original values. The user needs to enter 'y' for 'yes' or 'n' for no. If the user enters 'y' for 'yes', they will be asked whether they want to view the recipe once it has been reset 
