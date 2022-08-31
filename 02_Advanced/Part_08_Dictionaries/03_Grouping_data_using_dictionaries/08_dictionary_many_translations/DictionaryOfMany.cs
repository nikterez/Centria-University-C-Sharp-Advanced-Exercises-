using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_008_dictionary_many_translations
{
    public class DictionaryOfMany
    {
        private Dictionary<string, List<string>> dict;


        public DictionaryOfMany()
        {
            this.dict = new Dictionary<string, List<string>>();
        }

        public void Add(string word, string translation)
        {
            if (!this.dict.ContainsKey(word))
            {
                this.dict.Add(word, new List<string>());
            }
            this.dict[word].Add(translation);
        }

        public List<string> Translate(string word)
        {
            if(this.dict.ContainsKey(word))
            {
                return this.dict[word];
            }
            return new List<string>();
        }

        public void Remove(string word)
        {
            if (this.dict.ContainsKey(word))
            {
                this.dict.Remove(word);
            }
        }

    }
}