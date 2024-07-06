public class PrintInvoice {

    private Invoice? invoice;

    public void Print(Invoice? invoice) 
    {
        Console.WriteLine("title of Book: " + invoice?.getBook()?.getTitle());
        Console.WriteLine("Author of Book: "+invoice?.getBook()?.getAuthor());
        Console.WriteLine("price of Book: " + invoice?.getBook()?.getPrice());
        Console.WriteLine("quantity: " + invoice?.getQuantity());
        Console.WriteLine("Discount: " + invoice?.getDiscount());
        Console.WriteLine("Total: " + invoice?.getTotal()+"\n");

    }

    
}

