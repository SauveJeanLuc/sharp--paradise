namespace HelloWorld.Static;


// On Class members, will make there to be a single copy of the type
// member. i.e: All Objects of class share same static variable.

public class StaticMember
{
    public static int Age = 61;
    public string Name = "Aphro";
    
}

// class Program{
//     static void Main(string[] args)
//     {
//         StaticMember first = new StaticMember();
//
//         
//         StaticMember second = new StaticMember();
//         
//         Console.WriteLine();
//     }
// }