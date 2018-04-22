using System;
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

        private int[] VAC_2018 = new int[] {208, 348, 458, 462, 543, 714,
                                            805, 828, 1027,1221,1231,
                                            1237,1264,1333,1334,1352,
                                            1357, 1360,
                                            1377,1427,1462,1470,1640,
                                            1962,2043,2046,2178};

        public TextAnalyser(String text)
        {
            this.text = text;
        }


        public IEnumerable<Article> Parse()
        {
            string[] collection = text.Split(new char[] { '\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
            int current_index = 1;
            bool flagNextStep = false;
            foreach (var el in collection)
            {
                
                string current_index_s = current_index.ToString();
                string indexPattern = @"^" + current_index + @"\. ";
                
                if (Regex.IsMatch(el, indexPattern))
                {
                    var _article_index = (current_index - 1).ToString();
                    
                    flagNextStep = false;
                    if (articles.Keys.Contains(current_index_s))
                        throw new NotSupportedException();
                    if(current_index != 1)
                        articles[_article_index].finallyzeSpec();
                    articles.Add(current_index_s, new Article());
                    articles[current_index_s].articleName = current_index.ToString();
                    current_index++;
                }
                string article_index = (current_index - 1).ToString();
                if (flagNextStep)
                    continue;
                
                var specs = Regex.Matches(el, Speciality.REGEX_PATTERN_IN_STRING);
                    
                foreach (Match match in specs)
                {
                    articles[article_index].addSpeciality(new Speciality(match.Value.Substring(0,match.Value.Length-1)));
                }
                if (Regex.IsMatch(el, @"(^|; )(c|с) ([0-9]{2}\.){2}[0-9]{4}"))
                    articles[article_index].dateCounterHelper += 1;



            }

            return articles.Values
                           .Where(x=>!VAC_2018.Contains(int.Parse(x.articleName)))
                           .ToList()
                           .Where(x=>x.scientificSpecialities.Count > 0); 

        }

    }
}
