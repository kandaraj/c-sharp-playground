namespace InterfaceSegregationPrinciple.WithoutISP
{
    public class DVD : ILibraryItem
    {
        public string Author { get; set; } = ""; // not valid
        public int Pages { get; set; } = 0; // not valid
        public string Title { get; set; } // valid
        public string Borrower { get; set; } // valid
    }
}