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

Dictionary<string, decimal> cart = new Dictionary<string, decimal>(); //initialize shopping list dictionary



Console.WriteLine("Welcome to Doria Market!");

//display menu items
foreach (KeyValuePair<string, decimal> item in menu) //loop through all the items in the 'menu' dictionary
{
    Console.WriteLine(item.Key + "         $" + item.Value); //on running, space between item name and price is uneven
}


do
{
    Console.WriteLine("What would you like to order?"); //prompt the user to add an item to their order

    string userInput = Console.ReadLine().ToLower(); //take user input and convert it to lowercase for consistency


    if (menu.ContainsKey(userInput)) //if the 'menu' dictionary contains the item the user wants to order:
        {
            cart.Add(userInput, menu[userInput]);  //add the item to the 'cart' dictionary
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

//display cart items
Console.WriteLine("\n \n Cart \n");
foreach (KeyValuePair<string, decimal> item in cart) //loop through all the items in the 'cart' dictionary
{
    Console.WriteLine(item.Key + "         $" + item.Value); //on running, space between item name and price is uneven
}
Console.WriteLine("Total: $" + cart.Values.Sum()); //calculate the total of cart items and display for the user
; //display this message when the user is done shopping

//sort the cart dictionary by value in descending order. use that to display the most expensive item
//find the most expensive item in the user's cart using OrderByDescending on cart, then FirstOrDefault to get the first item in the sorted list. doesn't matter if the cart is initially empty.
KeyValuePair<string, decimal> mostExpensiveItem = cart.OrderByDescending(cart => cart.Value).FirstOrDefault();
Console.WriteLine("Your most expensive item was: " + mostExpensiveItem.Key);