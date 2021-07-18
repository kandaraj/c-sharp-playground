namespace InterfaceSegregationPrinciple.WithoutISP
{
    public interface ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
        
        string Title { get; set; }
        
        string Borrower { get; set; }
    }
}