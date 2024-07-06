public class saveInvoiceInFile {

    PrintInvoice data;
    public void save(string path) {

        using (StreamWriter str = new StreamWriter(path)) 
        { 
           str.WriteLine(data.ToString());
        }
    }
}

