using System;
internal class Program
{
    private static void Main(string[] args)
    {

        Book book = new Book("rich man",null,120);

        Invoice invoice = new Invoice(book, 1, 20, 100);

        PrintInvoice printInvoice= new PrintInvoice();

        // printInvoice.Print(invoice);

       // Console.WriteLine(invoice);

















        Console.ReadKey();
    }
}

/*
  The Single Responsibility Principle (SRP) is a principle of object-oriented programming that states(قائم علي) that every class,
  function, or module should have only one responsibility or function1.

    The benefit of following SRP is that it simplifies the code and prevents unexpected side effects of future changes.
    It also means that there should be only one reason to change a class, function, or module.
 
 */