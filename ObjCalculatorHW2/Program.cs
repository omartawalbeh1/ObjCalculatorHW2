using ObjCalculatorHW2;

class Program
{
    public static void Main(String[] args)
    {
        int x, y;
        Console.WriteLine("Enter Num1: ");
   x=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Enter Num2 : ");
        y = Convert.ToInt32(Console.ReadLine());
        Calculator cal1 = new Calculator(x,y);

        Console.WriteLine("Addition : " +cal1.Add());
        Console.WriteLine("Subtract : " +cal1.subtract());
        Console.WriteLine("Divide : "+ cal1.divide());
        Console.WriteLine("Multiply : "+cal1.multiply());

    }
}