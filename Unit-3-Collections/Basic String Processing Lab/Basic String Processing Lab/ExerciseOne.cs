// See https://aka.ms/new-console-template for more information
//Exercise One

bool promptSentence = true;

 void PromptSentenceInput()
{
    Console.WriteLine("Enter a sentence: ");
//initialize variable 'sentence' using user input.
    string sentence = Console.ReadLine();
//initialize an array variable 'sentence' using the Split method to create an array
    string[] words = sentence.Split(' ');
//loop through each index in the words array
    foreach (string word in words)
    {
        //print each index in the words array
        Console.WriteLine(word);
    }
}
//while userInput is turned on:
while (true)
{
    if (promptSentence)
    {
        PromptSentenceInput();
    }

    promptSentence = false;

    Console.WriteLine("Would you like to continue? (y/n)");
    string response = Console.ReadLine().ToLower();
    
    if (response.StartsWith("n"))
    {
        Console.WriteLine("Goodbye!");
        break; //end the loop
    } else if (response.StartsWith("y"))
    {
        promptSentence = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Would you like to continue?");
    }
   

}    

//Exercise Two
bool promptString = true;
List<String> strings = [];

void PromptStringInput()
{
    Console.WriteLine("Enter some text:");
    strings.Add(Console.ReadLine());
}

while (true)
{
    if (promptString)
    {
        PromptStringInput();
    }

    promptString = false;
    Console.WriteLine("You have entered: " + string.Join(" ", strings));
    Console.WriteLine("Would you like to continue? (y/n)");
     
    string response = Console.ReadLine().ToLower();
    
    if (response.StartsWith("n"))
    {
        Console.WriteLine("Goodbye!");
        break; //end the loop
    } else if (response.StartsWith("y"))
    {
        promptString = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Would you like to continue?");
    }
}