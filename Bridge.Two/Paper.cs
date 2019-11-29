using System;

namespace Bridge.Two
{
    public class Paper : Manuscript
    {
        public Paper(IFormatter formatter) : base(formatter)
        {
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine(formatter.Format("Author", Author));
            Console.WriteLine(formatter.Format("Text", Text));
            Console.WriteLine(formatter.Format("References", References));
        }
    }
}
