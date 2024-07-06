public class Book {

    private string? title;
    private string? author;
    private double? price;

    public Book(string? title,string? author, double? price) 
    {
        setTitle(title);
        setAuthor(author);
        setPrice(price);
    }

    public void setTitle(string? title) { this.title = title ?? "null"; }
    public void setAuthor(string? author) { this.author = author ?? "null"; }
    public void setPrice(double? price) { if (price is null) this.price = null; else this.price = price; }
    public string? getTitle() { return this.title; }
    public string? getAuthor() { return this.author; }
    public double? getPrice() { return this.price;}



    public override string ToString()
    {
        return "name: " + this.title + "\nauthor: " + this.author + "\nprice: " + this.price + "\n";
    }


}

