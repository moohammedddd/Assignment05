namespace Assignment05
{
    internal class Program
    {
        #region Part01
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authours { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }

            public Book(string _ISBN, string _Title, String[] _Autrour,
                               DateTime _PublicationDate, decimal _Price)
            {
                ISBN = _ISBN;
                Title = _Title;
                Authours = _Autrour;
                PublicationDate = _PublicationDate;
                Price = _Price;

            }


            public override string ToString()
            {
                string AuthourStr = "";
                for (int i = 0; i < Authours.Length; i++)
                {
                    AuthourStr += Authours[i];

                    if (i < Authours.Length - 1)
                    {
                        AuthourStr += " , ";
                    }
                }

                return $"ISBN: {ISBN}, Title: {Title}, Authors: {AuthourStr}, " +
              $"Publication Date: {PublicationDate:yyyy-MM-dd}, Price: {Price}";


            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region Part01
            Book book1 = new Book("978-3-16-148410-0", "C# Programming",
               new string[] { "John Doe", "Jane Smith" }, new DateTime(2024, 2, 16), 49.99M);
            Book book2 = new Book("978-3-16-148410-0", "C# Programming",
               new string[] { "John Doe", "Jane Smith" }, new DateTime(2024, 2, 16), 49.99M);

            Console.WriteLine(book1);
            string Price = BookFunction.GetPrice(book1);
            Console.WriteLine(Price);
             string Authours = BookFunction.GetAuthour(book1);
            Console.WriteLine(Authours);
             string Title = BookFunction.GetTitle(book1);
            Console.WriteLine(Title);
            #endregion
        }

        #region Part01 Method
        public class BookFunction
        {
            public static string GetTitle(Book B)
            {
                return B.Title;
            }
            public static string GetAuthour(Book B)
            {
                string AuthourStr = " ";
                for (int i = 0; i < B.Authours.Length; i++)
                {
                    AuthourStr += B.Authours[i];

                    if (i < B.Authours.Length - 1)
                    {
                        AuthourStr += " , ";
                    }
                }
                return AuthourStr;
            }
            public static string GetPrice(Book B)
            {
                return B.Price.ToString();
            }
        }
        #endregion



    }
}
