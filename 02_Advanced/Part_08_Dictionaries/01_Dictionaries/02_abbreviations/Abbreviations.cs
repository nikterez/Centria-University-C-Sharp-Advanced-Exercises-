using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_002_abbreviations
{
    public class Abbreviations
    { 
        private Dictionary<string,string> abr;

        public Abbreviations()
        {
            this.abr = new Dictionary<string, string>();
        }
        
        public void AddAbbreviation(string abbreviation, string explanation)
        {
            this.abr.Add(abbreviation,explanation);
        }

        public bool HasAbbreviation(string abbreviation)
        {
            if(this.abr.Keys.Contains(abbreviation))
            {
                return true;
            }
            return false;
        }

        public string FindExplanationFor(string abbreviation)
        {
            if(HasAbbreviation(abbreviation))
            {
                return this.abr[abbreviation];
            }
            
            return "Not found";
        }


    }
}