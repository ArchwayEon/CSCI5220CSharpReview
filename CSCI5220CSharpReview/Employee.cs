namespace CSCI5220CSharpReview;

internal class Employee
{
    public string Name { get; set; } = String.Empty; // Property

    public virtual string Talk()
    {
        return Name + ": blah blah blah!";
    }
}
internal class Manager : Employee
{
    public override string Talk()
    {
        return Name + ": GET BACK TO WORK!";
    }
}

