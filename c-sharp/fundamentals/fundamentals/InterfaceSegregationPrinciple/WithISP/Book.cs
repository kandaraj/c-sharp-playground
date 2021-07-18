namespace InterfaceSegregationPrinciple.WithISP
{
    public class Book: IBorrowableBook
    {
        public string Borrower { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Title { get; set; }
    }
}