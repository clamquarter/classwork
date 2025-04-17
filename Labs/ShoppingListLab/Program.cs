// See https://aka.ms/new-console-template for more information

//initialize menu Dictionary
//** on running, Doubles are being rounded to the nearest decimal point.
Dictionary<string, double> menu = new Dictionary<string, double>() {
    {"banana", 0.34},
    {"apple", 1.27},
    {"milk", 4.50},
    {"eggs", 32.80},
    {"ice cream", 7.99},
    {"bread", 2.87},
    {"carrot", 0.60},
    {"raw honey", 8.90},
};

//initialize shopping list dictionary
Dictionary<string, double> cart = new Dictionary<string, double>();

Console.WriteLine("Welcome to Doria Market!");

//display menu items
foreach (KeyValuePair<string, double> item in menu)
{
    Console.WriteLine(item.Key + "         $" + item.Value); //on running, space between item name and price is uneven
}

do { 
//take user order
Console.WriteLine("What would you like to order?");
string userInput = Console.ReadLine();
bool stillShopping = true;

    foreach (KeyValuePair<string, double> item in menu)
    {
        if (userInput.ToLower() == item.Key.ToLower())
        {
            cart.Add(item.Key, item.Value);
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that item.");
        }

        Console.WriteLine("You have " + cart.Count + " item in your cart. Would you like to order anything else? (y/n)");

        //if the user is done shopping, exit the loop. otherwise it will continue
        if (Console.ReadLine().ToLower() == "no")
        {
            stillShopping = false;
        }

    } while stillShopping == true;