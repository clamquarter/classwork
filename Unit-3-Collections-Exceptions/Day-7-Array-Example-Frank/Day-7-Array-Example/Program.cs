namespace Day_7_Array_Example;

using System;

class Program
    {
        /**************************************************************************************
<<<<<<< HEAD
         * This app will receive up to 10 numbers from the user
         *
         * After the user has indicated they have no more numbers to enter
         *             or 10 numbers have been entered...
=======
         * This app will receive up to 5 numbers from the user
         *
         * After the user has indicated they have no more numbers to enter
         *             or 5 numbers have been entered...
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
         *               
         * We will display each or the numbers entered with an indicator if number odd or even,
         *                 their sum and average
         *
         * Since we need to do something after we have all the numbers,
         *     rather than as we get each number
         *
         * We need to store the number the user entered and process them all when user is done
         *
         * We need to have some way for the user to tell us they are done entering numbers
         *****************************************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to my app!");       // Verify the app started

<<<<<<< HEAD
            // Define a constant to use to reference the size of the array
            const int ARRAY_SIZE = 5;  // use this every where you want to code the size of the array

            // Define an array to hold up to 10 numbers entered by the user
            double[] theNumbers = new double[ARRAY_SIZE];  //define an array of 10 doubles
=======
            // const marks the variable as a constant
            // a constant cannot be changed once it is assigned a value
            // constant names should be all UPPERCASE with _ to separate the parts of a name
            // Define a constant to use to reference the size of the array
            const int ARRAY_SIZE = 5;  // use this everywhere you want to code the size of the array
            
            // Define an array to hold up to ARRAY_SIZE numbers entered by the user
            double[] theNumbers = new double[ARRAY_SIZE];  //define an array of ARRAY_SIZE doubles
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)

            // Define a variable to hold the user input
            string whatUserTyped = "";

            // Define a variable to hold the sum of number
            double theSum = 0;

            // Define a variable to hold the number of variables entered by the user
            int numberEntered = 0;

<<<<<<< HEAD
            // Set up a loop to get ARRAY_SIZE numbers, one at a time or responses indicating the user is done
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                if (!moreInput()) // if they don't have any more input...
                {
                    break;  // exit the for-loop
                }
                // At this point we know the user has a number to enter

                // Call the method to get a numeric value
                theNumbers[i] = GetANumber();  // get the number and store in the next array element

                numberEntered++;  // Count a number being entered
            }
=======
            
            // When you need to process an array from start to end
            // Use a for-loop
            // for(int i=0; i<size-of-array; i++) - use i as the index into the array inside the loop
            
            // Set up a loop to get ARRAY_SIZE numbers, one at a time or responses indicating the user is done
            for (int i = 0; i < ARRAY_SIZE; i++)  // instead of ARRAY_SIZE theNumbers.Length is OK too
            {
             // if (moreInput() != true)  // alternate coding style   
                if (!moreInput()) // if they don't have any more input... moreInput() is a method returning true or false
                {
                    break;  // exit the for-loop before its gone through all iterations
                }
                // At this point we know the user has a number to enter

                // Call the method to get a numeric value and store it in the current array element indicated by i
                theNumbers[i] = GetANumber();  // get the number and store in the next array element

                numberEntered++;  // Count a number being entered
            }  // end of for-loop - break send us to ine after this
            
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
            // Since the variable i has the number of times through the loop
            // Can we use it after the loop to store the number of values entered?
            //
            // numberEntered = i;
            //
            // NO! i is defined in the for loop - so it can be used inside the for-loop (scope)

            // So now the array has all the numbers entered by the user

            Console.WriteLine("So I received "+ numberEntered + " numbers from you");

            // Go through the array and display each number, whether it's odd or even
            // Only process the numbers that were entered. i.e. NOT arrayname.length
            for (int i = 0; i < numberEntered; i++)
            {
<<<<<<< HEAD
=======
                // The ternary operator: condition ? value-if-true : value-if-false
                //
                //   (is array element evenly disible by 2 ? yes-Even : no-Odd)
                //   theNumbers[i] % 2 == 0 ? "Even" : "Odd"
                //
                // % - modulus operator - returns the remainder after an integer divide
                // Use % when you want to know if something is evenly divisble by something else
                //
                //     6 % 2 - return 0
                //     7 % 2 - return 1
                //    101 % 33 - return 2 (100 / 33 - 3 with remainder 2 (99 + 2)
                //
                // If you divide a number by 2 and remainder is 0, it's Even
                //                                 remainder is 1, it's Odd
                
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
                Console.WriteLine("Element #: " + i + " is: " + theNumbers[i] 
                                + " it is " + (theNumbers[i] % 2 == 0 ? "Even" : "Odd"));

                theSum = theSum + theNumbers[i];
            }

            Console.WriteLine("The sum of the numbers is: " + theSum);
            Console.WriteLine("The avg of the numbers is: " + theSum / numberEntered);

            Console.WriteLine("\nThanks for using my app!"); // Verify the app ended

            Console.WriteLine("\nPress enter to end program...");
            Console.ReadLine();
        } // End of Main()

        /****************************************************************
         * Helper methods used by Main()
         ******************************************************************/

<<<<<<< HEAD
        // return a boolean value to indicate if teh user has more input
        static bool moreInput()
        {
            bool   isThereInput  = false;  // Hold teh return value 

            string whatUserTyped = "";     // Hold what the user enters

            bool   getInput      = true;   // Control the user interaction loop

=======
        // return a boolean value to indicate if the user has more input
        //  return true  if user entered "Y"
        //         false if user entered "N"
        static bool moreInput()
        {
            bool   isThereInput  = false;  // Hold the return value (indicate if we have valid input)

            string whatUserTyped = "";     // Hold what the user enters

            bool   getInput      = true;   // Control the user interaction loop (do-while)

            // do-while - loop while the condition is true
            // the condition is on the while part of  the loop at the bottom of loop
            // You will always loop at least once with a do-while 
            // (the loop condition is not checked until the end of the loop)
            // (unlike for-loop or while-loop where the condition is checked before you loop even once)
            //
            // We use a do-while loop because we need to ask teh user at least once is they have any input
            
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("Do you have any numbers to enter (Y/N)?");
                whatUserTyped = Console.ReadLine();

<<<<<<< HEAD
                whatUserTyped = whatUserTyped.ToUpper();

=======
                // Convert the user input to all uppercase - so we don't worry about case
                whatUserTyped = whatUserTyped.ToUpper();

                // Exttract the first character from the user input - Substring(start-index, #-of-chars)
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
<<<<<<< HEAD
                    getInput = false;
                    isThereInput = true;
=======
                    getInput = false;      // Done getting input - set loop control variable to false - end loop
                    isThereInput = true;   // Indicate  user has more input - set the more input indicator to true
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
                }
                else
                {
                    if (firstChar == "N")
                    {
<<<<<<< HEAD
                        getInput = false;
                        isThereInput = false;
                    }
                }
            } while (getInput); // Loop while we get input
=======
                        getInput = false;       // Done getting input - end loop
                        isThereInput = false;   // User has no more input
                    }
                }
            } while (getInput); // Loop while we get input (while getInput == true)
           // while(getInput == true) // alternate way of coding
           // it's not necessary when you have bool variable since teh variable can only e true or false
           // so the variable name will be true or false no need to == or !=
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)

            return isThereInput;
        }

        // method starts with a method signature:  return-type name(parameters)

        // This method will get a numeric value from the user
        // It must be static because it will be used by the static method Main() (more later)
        // this method receives no parameters and returns a double (a double can also hold an int value)
        static double GetANumber()
        {
            // define a variable for the return value
            double theValue = 0;

            // Ask the user for a numeric value and have them keep trying until we get one

            bool isValidNumber = false;  // Determine is user entered a valid value

            // Loop until we get a valid numeric value

            do  // do loop is used so we ask the user for a number at least once
            {
                // Prompt the user to enter a numeric value
                Console.WriteLine("Please enter a number");

                // Get the input from the user
                string userInput = Console.ReadLine();
<<<<<<< HEAD
=======
                
                // Some statements may cause an Exception during processing
                // An exception is a error that occurs when the program runs (aka Runtime Exception)
                // When an Exception occurs a cryptic (to normal people) error message is displayed and
                //             the program stops
                //
                // You can handle an exception if it occurs in the program and let the program continue
                // with a try/catch blocks
                //
                // You put code that might cause an Exception in a try block try {}
                // followed by one or more catch blocks for the exception
                //   catch (exception-to-handle name-for-exception-object)
                //
                //   The exception object contains information about the exception you might use

>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)

                try // We want to handle an Exception that might occur in this block of code
                {
                    // Convert the user input to a double
                    theValue = double.Parse(userInput); // Could cause an Exception
<<<<<<< HEAD
                    isValidNumber = true;  // if .Parse() worked we have a valid number
=======
                    isValidNumber = true; // if .Parse() worked we have a valid number
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
                }
                // catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) // Handle a FormatException in previous try block
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + userInput);
<<<<<<< HEAD
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error
=======
                    Console.WriteLine(exceptionBlock
                        .Message); // Display the system message for the error from exception object
>>>>>>> 69aef14 (Instructor Push 04/16/2025 14:28:28)
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); // Loop while we don't have a valid number

            // return the double value from the user input
            return theValue;
        } // End of getANumber() method
    } // End of class Program