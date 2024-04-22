#region Task1

for (int i =0; i <= 20; i++)
{
    if (i == 13 || i == 17 || i == 19)
        continue; // Skip these numbers

    Console.WriteLine(i);
}

#endregion;

#region Task2

// Define an array of strings
string[] fruits = { "Apple", "Banana", "Orange", "Grapes", "Mango" };

// Display the values of the array elements
Console.WriteLine("Fruits:");

foreach (string fruit in fruits)

Console.WriteLine(fruit);

#endregion;

#region Task3

Console.Write("Enter your age: ");
if (int.TryParse(Console.ReadLine(), out int age))
{
    string ageGroup;

    if (age < 18)
    {
        ageGroup = "Youth";
    }
    else if (age >= 18 && age <= 35)
    {
        ageGroup = "Young";
    }
    else if (age > 35 && age <= 55)
    {
        ageGroup = "Middle Age";
    }
    else
    {
        ageGroup = "Old";
    }

    Console.WriteLine($"You are in the {ageGroup} age group.");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid age as a number.");
}

#endregion;

#region Task4

Console.Write("Enter the temperature: ");
if (int.TryParse(Console.ReadLine(), out int temperature))
{
    string temperatureRating;

    if (temperature < 10)
    {
        temperatureRating = "Cold";
    }
    else if (temperature >= 10 && temperature <= 20)
    {
        temperatureRating = "Medium temperature";
    }
    else if (temperature > 20)
    {
        temperatureRating = "Hot";
    }
    else
    {
        temperatureRating = "Invalid input";
    }

    Console.WriteLine($"The temperature rating is: {temperatureRating}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid temperature as a number.");
}

#endregion;



