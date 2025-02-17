
using System;
namespace CoffeeOrderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalBill = 0; // integer variable to keep track of  total bill
            bool buyAnother = false; // boolean variable to check user's choice on whether they want to buy another coffee


            Console.WriteLine("Welcome to the Coffee Shop!");

            // a do-while loop because we want the body askign for the user to choose coffie to oo always executes the first time regardless of the while check
            do
            {
                while (true)
                {
                    // Our cases, user will get to choose coffee size based on a integer value from 1 to 3 (1: small, 2: medium, 3: large)
                    Console.WriteLine("\nPlease select your coffee size:");
                    Console.WriteLine("1 - Small ($3)");
                    Console.WriteLine("2 - Medium ($5)");
                    Console.WriteLine("3 - Large ($7)");
                    Console.Write("Your choice: ");

                    // User puts in their coffee size choice, and we check to see if their input is an integer value (TryParse(….out int…))
                    if (int.TryParse(Console.ReadLine(), out int coffeeChoice))
                    {
                        switch (coffeeChoice)
                        {
                            // if the user inputs 1 (again, integer value), then they are ordering a small coffee worth $3
                            case 1:
                                Console.WriteLine("You chose a Small coffee.");
                                totalBill += 3;  // adding 3 to the variable totalBill (that keeps track of total)
                                break;

                            // if the user inputs 2, then they are ordering a medium size coffee worth $ 4
                            case 2:
                                Console.WriteLine("You chose a Medium coffee.");
                                totalBill += 5; //adding 5 to the total variable totalBill
                                break;

                            // if the user inputs 3, then they are ordering a large size coffee worth $7
                            case 3:

                                Console.WriteLine("You chose a Large coffee.");
                                totalBill += 7;	 //adding 7 to the total variable totalBill
                                break;

                            // for any other integer value the user inputs, the input is an invalid option ( value less than 1 or greater than 3)
                            default:
                                Console.WriteLine($"Your choice '{coffeeChoice}' is invalid.\nPlease try again.");
                                continue; // in that case, the program loops back again asking for a coffee size
                        }
                        break;
                    }

                    // if the check to see if user input is an integer value finds that the user input is a string value, ( i.e. TryParse(….out int…) gives false) then we give out a messsage saying they did not put in a number and to try again, and the program loops back again asking for a coffee size
                    else
                    {
                        Console.WriteLine("Invalid input (not a number). Please try again.");
                    }
                }

                // if a valid coffee size was given, then the user has the option to buy another coffee 
                Console.Write("\nDo you want to buy another coffee? (Yes or No): ");

                // currently, we don't know if the user wants to buy another coffee
                buyAnother = false;

                //string varibale to hold the user's response
                string buyAnotherInput;

                // while loop to check if a valid a yes/no resposne is given
                while (!buyAnother)
                {
                    // take the users response 
                    buyAnotherInput = Console.ReadLine().ToLower();

                    // if the user's response is not a valid yes/no
                    if (buyAnotherInput.ToLower() != "yes" || buyAnotherInput.ToLower() != "no")
                    {

                        Console.Write("\nYou did not give a valid answer. Please type 'Yes' or 'No')");

                        Console.Write("\nDo you want to buy another coffee? (Yes or No): ");

                        //then the user has to re-input a yes/no resopnse
                        continue;
                    }
                    //if a valid yes/no response is given, then we buyAnotherInput is true (boolean variable checking to see if response is valid), and the while loop breaks
                    else
                    {
                        buyAnother = true;
                    }

                }
            }
            // the while case in do-while: after the user inputs a valid coffee size option, they then have the option to buy another coffee ( Yes: body inside the do exectues again propmting the user to choose a coffee size, until the user chooses No: the program exists )
            while (buyAnother);

            // if the user chose 'no', then give total and exit the program after user presses a key 
            Console.WriteLine($"\nThank you for shopping with us!");
            Console.WriteLine($"Your total bill is: ${totalBill}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}