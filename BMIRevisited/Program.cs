// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//flags for do while loops
bool validGender = false;
bool validAge = false;
bool metric = false;
bool validUnits = false;
bool validWeight = false;
bool validHeight = false;

string gender = "";
string units = "";
int age = 0;
double weight = 0;
double height = 0.0;

// checking gender
do
{
    Console.WriteLine("Please enter a gender (male/female): ");
    gender = Console.ReadLine();
    if (gender != "female" && gender != "male")
    {
        Console.WriteLine("Invalid option, please try again.");
    }
    else
    {
        validGender = true;
    }
} while (!validGender);

// checking age
do
{
    try
    {
        Console.WriteLine("Please enter your age: ");
        age = int.Parse(Console.ReadLine());
    }
    catch (FormatException ex)// if not a number
    {
        Console.WriteLine("Invalid age, please try again.");
        Console.WriteLine("Number Format Exception " + ex.Message);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("That's way too big! Invalid age, please try again." + ex.Message);
    }

    if (age <= 0)// negative ages
    {
        Console.WriteLine("Invalid age, please try again.");
    }
    else
    {
        validAge = true;
    }

} while (!validAge);

// checking metric or imperial calculations before height and weight
do
{
    Console.WriteLine("Please indicate whether you would like to use metric or imperial by typing the word: ");
    units = Console.ReadLine();
    if (units != "metric" && units != "imperial")
    {
        Console.WriteLine("Please provide a valid input: metric or imperial.");
    }
    else
    {
        validUnits = true;// using seperate boolean flag for this do while loop
        if (units == "metric")
        {
            metric = true;
        } // else metric = false
    }
} while (!validUnits);

//checking height
do
{
    if (metric)
    {
        Console.WriteLine("Please enter your height in cm");
        try
        {
            height = double.Parse(Console.ReadLine()) / 100;//converting cm to m
        }
        catch (FormatException ex)//not a number
        {
            Console.WriteLine("Please enter a valid height");
            Console.WriteLine("Number format exception: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected exception: " + ex.Message);
        }

    }
    else
    {
        Console.WriteLine("Please enter your height in feet and inches in the form feet\"inches");
        try
        {
            string[] total = Console.ReadLine().Split("\"");
            height = double.Parse(total[0]) * 12 + double.Parse(total[1]);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a valid height.");
            Console.WriteLine("Format exception : " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Overflow exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception :" + ex.Message);
        }
    }

    if (height <= 0.0)// height already set to 0 earlier
    {
        Console.WriteLine("Please enter a valid height.");
    }
    else
    {
        validHeight = true;
    }

    
} while (!validHeight);

//checking weight
do
{
    if (metric)
    {
        Console.WriteLine("Please enter your weight in kilograms: ");
        try
        {
            weight = double.Parse(Console.ReadLine());
        } catch (FormatException ex)//not a number
        {
            Console.WriteLine("Invalid input, please try again.");
            Console.WriteLine("Format exception: " + ex.Message);
        }
        catch (OverflowException ex)// too large
        {
            Console.WriteLine("Overflow exception: " + ex.Message);
        } 
        catch (Exception ex)// general exceptions
        {
            Console.WriteLine("General exceptions : " + ex.Message);
        }
    }
    else// imperial
    {
        Console.WriteLine("Please enter your weight in pounds:");
        try
        {
            weight = double.Parse(Console.ReadLine());
        }
        catch (FormatException ex)// not a number
        {
            Console.WriteLine("Invalid input, please try again");
            Console.WriteLine("Format exception: " + ex.Message);
        }
        catch (OverflowException ex)// too large 
        {
            Console.WriteLine("Overflow exception: " + ex.Message);
        }
        catch (Exception ex)// general exceptions
        {
            Console.WriteLine("General exception: " + ex.Message);
        }

    }
    if (weight <= 0.0)// weight already set to 0 from earlier 
    {
        Console.WriteLine("Invalid input, please try again.");
    }
    else
    {
        validWeight = true;
    }
} while (!validWeight);

//calling BMI classs from other file to calculate BMI 
BMIRevisited.BMI person = new BMIRevisited.BMI(gender, age, height, weight, metric);
Console.WriteLine(person.CalculateBMI());// outputting BMI and weight classification to user
Console.ReadLine();