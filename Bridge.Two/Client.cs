using System;

namespace Bridge.Two
{
    class Client
    {
        static void Main(string[] args)
        {
            IFormatter fomatter1 = new FancyFormatter();
            Book book = new Book(fomatter1)
            {
                Author = "Robert C. Martin",
                Title = "Clean Code",
                Text = "Text of the book"
            };
            book.Print();
            Console.WriteLine("*************************************************************");
            IFormatter fomatter2 = new StandardFormatter();
            Paper paper = new Paper(fomatter2)
            {
                Author = "Author",
                Title = "Paper title",
                Text = "Text of the paper",
                References = "References of the paper"
            };
            paper.Print();
            Console.ReadLine();

        }
    }
}
