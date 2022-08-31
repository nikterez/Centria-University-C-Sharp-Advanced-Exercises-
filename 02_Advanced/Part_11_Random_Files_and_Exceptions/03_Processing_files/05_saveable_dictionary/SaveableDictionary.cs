using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace _05_saveable_dictionary
{
    public class SaveableDictionary
    {
        private string file;
        private Dictionary<string, string> dic;

        public SaveableDictionary(string file)
        {
            this.file = file;
            this.dic = new Dictionary<string, string>();
        }

        public SaveableDictionary()
        {
            this.dic = new Dictionary<string, string>();
        }
        public void Add(string words, string translation)
        {
            if (!this.dic.Keys.Contains(words))
            {
                this.dic.Add(words, translation);
            }
        }

        public void Delete(string word)
        {
            if (this.dic.ContainsKey(word))
            {
                this.dic.Remove(word);
            }

            foreach (var item in this.dic)
            {
                if (item.Value.Contains(word))
                {
                    this.dic.Remove(item.Key);
                }
            }

        }

        public string Translate(string word)
        {
            if (this.dic.ContainsKey(word))
            {
                return this.dic[word];
            }

            foreach (var item in this.dic)
            {
                if (item.Value.Contains(word))
                {
                    return item.Key;
                }
            }

            return null;

        }

        public bool Load()
        {
            bool exc = false;
            string[] line = null;

            try
            {
                line = File.ReadAllLines(file);

                foreach (var sentence in line)
                {
                    try
                    {
                        string[] word = sentence.Split(":");
                        Add(word[0], word[1]);
                    }
                    catch (Exception)
                    {
                        exc = true;
                        continue;
                    }

                }
            }
           
            catch (Exception)
            {
                exc = true;
            }

            if (exc)
            {
                return false;
            }

            return true;

        }

        public bool Save()
        {
            try
            {
                StreamWriter writer = new StreamWriter("test.txt");

                foreach (var item in this.dic)
                {
                    writer.WriteLine(item.Key + ":" + item.Value);
                }
                writer.Close();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public void Print()
        {
            foreach (var item in this.dic)
            {
                System.Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
