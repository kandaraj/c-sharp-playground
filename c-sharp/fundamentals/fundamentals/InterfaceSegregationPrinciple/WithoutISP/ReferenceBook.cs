namespace InterfaceSegregationPrinciple.WithoutISP
{
    
    public class ReferenceBook: ILibraryItem
    {
        public string Author { get; set; } // valid
        public int Pages { get; set; } // valid
        public string Title { get; set; } // valid
        public string Borrower { get; set; } // reference book cant be borrowed
    }
}