﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace VAC_Statistic.Core
{
    class TextAnalyser
    {
        String text;
        Dictionary<String, Article> articles = new Dictionary<string, Article>();

        public TextAnalyser(String text)
        {
            this.text = text;
        }


        public IEnumerable<Article> Parse()
        {
            string[] collection = text.Split(new char[] { '\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
            int current_index = 1;

            foreach (var el in collection)
            {
                string current_index_s = current_index.ToString();
                string indexPattern = @"^" + current_index + @"\. ";
                
                if (Regex.IsMatch(el, indexPattern))
                {
                    if (articles.Keys.Contains(current_index_s))
                        throw new NotSupportedException();
                    if(current_index != 1)
                        articles[(current_index - 1).ToString()].finallyzeSpec();
                    articles.Add(current_index_s, new Article());
                    current_index++;
                }
                string article_index = (current_index - 1).ToString();

                
                var specs = Regex.Matches(el, Speciality.REGEX_PATTERN_IN_STRING);
                    
                foreach (Match match in specs)
                {
                    articles[article_index].addSpeciality(new Speciality(match.Value.Substring(0,match.Value.Length-1)));
                }
                if (Regex.IsMatch(el, @"(^|; )(c|с) ([0-9]{2}\.){2}[0-9]{4}"))
                    articles[article_index].dateCounterHelper += 1;


            }

            return articles.Values
                           .ToList()
                           .Where(x=>x.scientificSpecialities.Count > 0); 

        }

    }
}
