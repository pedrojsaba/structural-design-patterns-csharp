namespace Bridge.Two
{
    public abstract class Manuscript
    {

        protected IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        abstract public void Print();
    }
}
