using CSCI5220CSharpReview;
using System.Text.Json;

//Console.WriteLine("Hello, World!");
//EnumDemo();
//ClassDemo();
//InterfaceDemo();
//ArrayDemo();
//ImplicitTypeDemo();
AnonymousDemo();

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

static void InterfaceDemo()
{
    IAreaReporter r = new Rectangle { Length = 20, Width = 10 };
    Console.WriteLine($"The area of the shape is {r.GetArea()}");
}

static void ArrayDemo()
{
    // Declare a single-dimensional array  
    int[] array1 = new int[5];

    string a1str = String.Join(",", array1);

    // Declare and set array element values 
    int[] array2 = new int[] { 1, 3, 5, 7, 9 };

    string a2str = String.Join(",", array2);

    // Alternative syntax 
    int[] array3 = { 1, 2, 3, 4, 5, 6 };

    string a3str = String.Join(",", array3);

    // Declare a two-dimensional array 
    int[,] multiDimensionalArray1 = new int[2, 3];

    // Declare and set array element values 
    int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

    // Declare a jagged array 
    int[][] jaggedArray = new int[6][];

    // Set the values of the first array in the jagged array structure
    jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

    Console.WriteLine($"Array 1 [{a1str}] Array 2 [{a2str}] Array 3 [{a3str}]");
}

static void ImplicitTypeDemo()
{
    // i is compiled as an int 
    var i = 5;

    // s is compiled as a string 
    var s = "Hello";

    // a is compiled as int[] 
    var a = new[] { 0, 1, 2 };

    // list is compiled as List<int>                              
    var list = new List<int>();

    Console.WriteLine(
        $"i = {i}, s = {s}, a = [{String.Join(",", a)}], list = [{String.Join(",", list)}]");
}

static void AnonymousDemo()
{
    var o = new { Amount = 108, Message = "Hello" };

    var ojson = JsonSerializer.Serialize(o);

    var v = new { Key = 42, Value = "Hello" };

    var vjson = JsonSerializer.Serialize(v);

    var anonArray =
        new[] {
            new { name = "apple", diam = 4 },
            new { name = "grape", diam = 1 }
        };

    var ajson = JsonSerializer.Serialize(anonArray);

    Console.WriteLine($"o = {ojson}, v = {vjson}, anonArray = {ajson}");

}