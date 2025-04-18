// See https://aka.ms/new-console-template for more information

    bool stillShopping = true; //is the user still shopping? default to true so the program starts off allowing them to shop

// Fix for CS1950 and CS1503: Ensure all numeric literals are explicitly defined as decimal by appending 'm' to them.

Dictionary<string, decimal> menu = new Dictionary<string, decimal>() {
    {"banana", 0.34m},
    {"apple", 1.27m},
    {"milk", 4.50m},
    {"eggs", 32.80m},
    {"ice cream", 7.99m},
    {"bread", 2.87m},
    {"carrot", 0.60m},
    {"raw honey", 8.90m},
};

Dictionary<string, decimal> cart = new Dictionary<string, decimal>(); //initialize, shopping list dictionary

Dictionary<string, List<double>> gradeBook = new Dictionary<string, List<double>>();

Console.WriteLine("Welcome to Doria Mart!\n\n");
Console.WriteLine("{0,-10} \t\t{1,5}", "Item", "Price");
Console.WriteLine("==============================\n");

//display menu items
foreach (KeyValuePair<string, decimal> item in menu) //loop through all the items in the 'menu' dictionary
{
    Console.WriteLine("{0,-10} \t\t${1,5}", item.Key, item.Value); //format the output to align the prices in a column
}

do
{
    Console.WriteLine("\nWhat would you like to order?"); //prompt the user to add an item to their order

    string userInput = Console.ReadLine().ToLower(); //take user input and convert it to lowercase for consistency


    if (menu.ContainsKey(userInput)) //if the 'menu' dictionary contains the item the user wants to order:
        {
            cart.Add(userInput, menu[userInput]);  //add the item to the 'cart' dictionary
        Console.WriteLine("Adding " + userInput + " to your cart at $" + menu[userInput] + "."); //display a message confirming item was added to cart.
        } else
        {
            Console.WriteLine("Sorry, we don't have that item."); //if the item is not in the menu, display this message and the user will be prompted again.
        }

    
    Console.WriteLine("Would you like to order anything else? (y/n)");

    string userConfirmation = Console.ReadLine().ToLower();

    //if the user is done shopping, exit the loop. otherwise it will run again.
    while (true) {
        if (userConfirmation.StartsWith("n")) {
            stillShopping = false; //update the stillShopping bool to false, mark the user as done shopping.
            //mostExpensiveItem = cart.sor
            break; //end the loop/decision tree.

        } else if (userConfirmation.StartsWith("y")) {
            break; //if the user wants to order more items, break out of the while loop (this current nested decision tree) and continue the do-while loop (external decision tree)
            //continue loop
        } else
        {
            Console.WriteLine("Invalid input. Would you like to order anything else? (y/n)");
            userConfirmation = Console.ReadLine().ToLower(); //if the user input is not valid, prompt them again. this will repeat until they enter a valid response
        }
    }
} while (stillShopping);

//sort the cart by price in descending order and create a new dictionary with the sorted items.
Dictionary<string, decimal> descendingCart = (Dictionary<string, decimal>)cart.OrderByDescending(cart => cart.Value).ToDictionary();

//sort the cart by price in ascending order and create a new dictionary with the sorted items.
Dictionary<string, decimal> ascendingCart = (Dictionary<string, decimal>)cart.OrderBy(cart => cart.Value).ToDictionary();

KeyValuePair<string, decimal> mostExpensiveItem = descendingCart.FirstOrDefault(); //get the first item in the descending/highest to lowest priced cart.

KeyValuePair<string, decimal> cheapestItem = ascendingCart.FirstOrDefault(); //get the first item in the descending/lowest to highest priced cart.


//display cart items
Console.WriteLine("Thanks for shopping at Doria Mart!\n \nCart \n==============================\n");
foreach (KeyValuePair<string, decimal> item in ascendingCart) //loop through all the items in the 'ascendingCart' dictionary to show cart in order from least to most expensive item.
{
    Console.WriteLine("{0,-10} \t\t${1,5}", item.Key, item.Value); //on running, space between item name and price is uneven
}

Console.WriteLine("{0,-10} \t\t${1,5}", "Total: ", cart.Values.Sum()); //calculate the total of cart items and display for the user


Console.WriteLine("\nYour most expensive item was: " + mostExpensiveItem.Key + " at $" + mostExpensiveItem.Value + ", while your cheapest item was: " + cheapestItem.Key + " at $" + cheapestItem.Value + "."); //display the cheapest and most expensive items' names.