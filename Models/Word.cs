namespace dotnetcoretest.Models
{
    public class Word
    {
        public int Id {get; private set;}

        public Word(int id)
        {
            this.Id = id;
        }
    }
}