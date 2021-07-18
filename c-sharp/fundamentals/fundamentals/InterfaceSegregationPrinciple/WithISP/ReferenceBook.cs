namespace InterfaceSegregationPrinciple.WithISP
{
    
    public class ReferenceBook: IBook
    {
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}