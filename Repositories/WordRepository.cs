using System.Collections.Generic;
using dotnetcoretest.Models;
using System.Linq;

namespace dotnetcoretest.Repositories
{
    public class WordRepository
    {
        private static WordRepository instance;
        public static WordRepository Instance {get
        {
            if (instance == null)
            {
                instance = new WordRepository();
            }

            return instance;
        }}

        public IList<Word> Words {get; set;}
        public WordRepository()
        {
            Words = new List<Word>();
        }

        public void Add(Word word)
        {
            Words.Add(word);
        }

        public Word GetById(int id)
        {
            return Words.Single(x => x.Id == id);
        }

        public IList<Word> GetAll()
        {
            return Words;
        }
    }
}