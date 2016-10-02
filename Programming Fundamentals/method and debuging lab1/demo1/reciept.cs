using System;

public class Program
{
    public static void Main()
    {
        MainPrintReceipt();
    }
    public static void MainPrintReceipt()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
           
    }
    private static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
    private static void PrintBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }
    private static void PrintFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("© SoftUni");
    }
}

