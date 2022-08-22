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
        Console.WriteLine("Welcome to Adder");
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        string toPrint;

        toPrint =  AddNumbers(num1, num2) == 6 ? "Approved" : "Dissaproved";
        Console.WriteLine(toPrint);
    }
}
