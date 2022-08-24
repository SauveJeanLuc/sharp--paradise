using HelloWorld.Static;

namespace HelloWorld;

class Program
{
    public static int AddNumbers(int num1, int num2){
        int sum = num1 + num2;
        System.Console.WriteLine(sum);
        return sum;
    } 

    static void Main(string[] args)
    {
        // Console.WriteLine("Welcome to Adder");
        // Console.WriteLine("Enter a number");
        // int num1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter another number");
        // int num2 = Convert.ToInt32(Console.ReadLine());
        //
        // string toPrint;
        //
        // toPrint =  AddNumbers(num1, num2) == 6 ? "Approved" : "Dissaproved";
        // Console.WriteLine(toPrint);
        //
        // // Declaring an array
        // int[] age = new int[5];
        //
        // age[0] = 16;
        // age[1] = 5;
        //
        //
        // Console.WriteLine(age[0]);
        
        StaticMember first = new StaticMember();
        first.Name = "New Name";
        StaticMember.Age = 34;
        Console.WriteLine(first.Name);
        Console.WriteLine(StaticMember.Age);
        
        StaticMember second = new StaticMember();
        
        Console.WriteLine("Hello It worked!");
    }
}
