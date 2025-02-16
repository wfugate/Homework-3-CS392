// See https://aka.ms/new-console-template for more information

try
{
    Console.WriteLine("Gender: ");
    string gender = Console.ReadLine();
    Console.WriteLine("Height (cm): ");
    string heightNonDouble = Console.ReadLine();
    double height = double.Parse(heightNonDouble);
    Console.WriteLine("Weight (kg): ");
    string weightNonDouble = Console.ReadLine();
    double weight = double.Parse(weightNonDouble);
    Console.WriteLine("Age: ");
    string ageNonInt = Console.ReadLine();
    int age = int.Parse(ageNonInt);

    if (height < 1 | weight < 1 | age < 1)
    {
        throw new ArgumentOutOfRangeException("Height, weight, and age must be greater than zero.");
    }
    BMICalculator2.BMI input = new BMICalculator2.BMI(gender, height, weight, age);
    double bmi = input.Calculate();
    Console.WriteLine($"Calculated BMI: " + bmi);


}
catch (FormatException ex)
{
    Console.WriteLine($"Incorrect Format: {ex.Message}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"That's too big: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected Error: {ex.Message}");
}
Console.ReadLine();