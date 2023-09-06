using CSCI5220CSharpReview;

//Console.WriteLine("Hello, World!");
//EnumDemo();
ClassDemo();


static void EnumDemo()
{
    Days today = Days.Monday;
    int dayNumber = (int)today;
    string model = $"{today} is day number #{dayNumber}.\n";

    foreach (string item in Enum.GetNames(typeof(Months)))
    {
        model += item + " ";
    }

    Console.WriteLine(model);
}

static void ClassDemo()
{
    Employee e = new()
    {
        Name = "Jeff"
    };
    Manager m = new()
    {
        Name = "Evelyn"
    };

    string model = e.Talk();
    model += Environment.NewLine;
    model += m.Talk();

    Console.WriteLine(model);
}



