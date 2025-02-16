// See https://aka.ms/new-console-template for more information


int size;
string response;
bool shopping = true;
int bill = 0;

do
{
    Console.WriteLine("Please Select Your coffee size: Enter (1) for small, (2) for medium, (3) for large.");
    int.TryParse(Console.ReadLine(), out size);
    if (size != 1 & size != 2 & size != 3) {
        Console.WriteLine("Your choice is invalid.");
    } else {
        bill += size;
        Console.WriteLine("Do you want to buy another coffee?");
        response = Console.ReadLine();
        switch (response.ToLower())
        {
            case "no":
                Console.WriteLine("Thank you for shopping with us.");
                Console.WriteLine("Bill Amount - " + bill.ToString());
                shopping = false;
                break;
            case "yes":
                break;

    }
    }
} while (shopping == true);