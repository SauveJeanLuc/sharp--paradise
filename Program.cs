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
        Console.WriteLine("Hello World!");
        AddNumbers(1, 2);
    }
}
