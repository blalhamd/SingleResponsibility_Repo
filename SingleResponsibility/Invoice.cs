public class Invoice {//(فاتورة)

    private Book? book;
    private int? quantity;
    private double? discount;
    private double? total;

    public Invoice(Book? book, int? quantity, double? discount, double? total)
    {
        this.book = book;
        setQuantity(quantity);
        setDiscount(discount);
        setTotal(total);
    }

    public void setQuantity(int? quantity) { if (quantity is null) quantity = null; else this.quantity = quantity; }
    public void setDiscount(double? discount) { if (discount is null) discount = null; else this.discount = discount; }
    public void setTotal(double? total) { if (total is null) total = null; else this.total = total; }
    public double? getDiscount() { return discount; }
    public double? getQuantity() { return quantity; }
    public double? getTotal() { return total; }
    public Book? getBook() { return this.book; }
    public double? calcPrice() 
    {
        double? price=(( book?.getPrice()-discount*book?.getPrice())-quantity);

        return price;
    }

    public override string ToString()
    {
        return "title of Book: " +book?.getTitle() +
               "\nAuthor of Book: " + book?.getAuthor() +
               "\nprice of Book: " + book?.getPrice() +
               "\nquantity: " + this.quantity+
               "\nDiscount: " + this.discount +
               "\nTotal: " + this.total + "\n";
    }
}

