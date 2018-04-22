using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VAC_Statistic.Core;
namespace VAC_Statistic
{
    class Statistic
    {

        public static string beautifulResult(IEnumerable<KeyValuePair<string,int>> pairs)
        {
            string ans = "";
            double sum = pairs.Sum(x => x.Value);
            foreach (var el in pairs)
            {
                ans += el.Key + "\t" + el.Value.ToString() + "\t" + Math.Round((((double) el.Value)/sum)*100,2)+"%";
                ans += "\r\n";
            }

            ans += "итоговая сумма : " + sum.ToString();
            return ans;
        }

        public static string beautifulResult(IEnumerable<KeyValuePair<string, double>> pairs)
        {
            string ans = "";
            double sum = pairs.Sum(x => x.Value);
            foreach (var el in pairs)
            {
                ans += el.Key + "\t" + el.Value.ToString() + "\t" + Math.Round((((double)el.Value) / sum) * 100, 2) + "%";
                ans += "\r\n";
            }

            ans += "итоговая сумма : " + sum.ToString();
            return ans;
        }


        public IEnumerable<KeyValuePair<string,int>> getBranchOfScienceDistribution(IEnumerable<Article> articles)
        {
            
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.FirstCode.ToString()+".00.00");
                }

                foreach (var spec in set)
                {
                    var specScienceCode = spec;
                    if (result.Keys.ToList().Contains(spec))
                        result[spec]++;
                    else
                        result.Add(spec, 1);
                }   
            }


            return result.ToList().OrderByDescending(x=>x.Value);
        }

        public IEnumerable<KeyValuePair<string, int>> getBranchOfScienceDistribution_OneDirection(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.FirstCode.ToString() + ".00.00");
                }
                if (set.Count > 1)
                    continue;
                foreach (var spec in set)
                {
                    var specScienceCode = spec;
                    if (result.Keys.ToList().Contains(spec))
                        result[spec]++;
                    else
                        result.Add(spec, 1);
                }
            }


            return result.ToList().OrderByDescending(x => x.Value);
        }

        public IEnumerable<KeyValuePair<string, int>> getDirectionsCount(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>() ;

            result.Add("1", 0);
            result.Add("2", 0);
            result.Add("3", 0);

            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.FirstCode.ToString());
                }

                result[set.Count.ToString()]++;
                
            }


            return result.ToList().OrderByDescending(x => x.Value);
        }

        public int getDirectionsPairCount(IEnumerable<Article> articles)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.FirstCode.ToString() + ".00.00");
                }
                if (set.Count != 2)
                    continue;
                var orderedList = set.ToList().OrderBy(x => x);
                result.Add(orderedList.First() + orderedList.Last());

            }

            return result.Count;
        }

        public IEnumerable<KeyValuePair<string, int>> getDirectionPairs(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();


            HashSet<string> resultSet = new HashSet<string>();
            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.FirstCode.ToString());
                }
                if (set.Count != 2)
                    continue;
                
                var orderedList = set.ToList().OrderBy(x => x);

                var bufKey = orderedList.First() +".00.00 И " + orderedList.Last()+".00.00";
                if (!result.Keys.ToList().Contains(bufKey))
                    result.Add(bufKey, 1);
                else
                    result[bufKey]++;

            }
            return result.ToList().OrderByDescending(x=>x.Value);
        }

        public IEnumerable<KeyValuePair<string, int>> getDirectionThirds(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();


            HashSet<string> resultSet = new HashSet<string>();
            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.FirstCode.ToString());
                }
                if (set.Count != 3)
                    continue;

                var orderedList = set.ToList().OrderByDescending(x => x).ToList();

                var bufKey = orderedList[0] + ".00.00 И "+ orderedList[1]+ ".00.00 И " + orderedList[2] + ".00.00";
                if (!result.Keys.ToList().Contains(bufKey))
                    result.Add(bufKey, 1);
                else
                    result[bufKey]++;

            }
            return result.ToList().OrderByDescending(x => x.Value);
        }


        public IEnumerable<KeyValuePair<string, int>> getObjectsDirection(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();

            //result.Add("1", 0);
            //result.Add("2", 0);
            //result.Add("3", 0);
            //result.Add("4", 0);
            //result.Add("5", 0);
            //result.Add("6", 0);

            //foreach (var el in articles)
            //{
            //    result[el.scientificSpecialities.Count.ToString()]++;
            //}
            var lnk = articles.Where(x => x.scientificSpecialities.Count == 1);
            foreach (var el in lnk)
            {
                result.Add(el.articleName, el.scientificSpecialities.Count);
            }

            return result.ToList().OrderByDescending(x => x.Value);
        }

        public IEnumerable<KeyValuePair<string, int>> getGNSDistribution(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();
            
            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.Code);
                }

                foreach (var spec in set)
                {
                    var specScienceCode = spec;
                    if (result.Keys.ToList().Contains(spec))
                        result[spec]++;
                    else
                        result.Add(spec, 1);
                }
            }


            return result.ToList().OrderByDescending(x => x.Value);
        }

        public IEnumerable<KeyValuePair<string, int>> getGNSCount(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();

            result.Add("1", 0);
            result.Add("2", 0);
            result.Add("3", 0);
            result.Add("4", 0);
            result.Add("5", 0);

            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.Code);
                }
                if(set.Count > 0 && set.Count < 6)
                    result[set.Count.ToString()]++;

            }


            return result.ToList().OrderByDescending(x => x.Value);
        }


        public IEnumerable<KeyValuePair<string, int>> getGNSDistributionWithouDirections(IEnumerable<Article> articles)
        {
            
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    if (spec.SecondCode == 0 && spec.ThirdCode == 0)
                        continue;
                    set.Add(spec.Code);
                }

                foreach (var spec in set)
                {
                    var specScienceCode = spec;
                    if (result.Keys.ToList().Contains(spec))
                        result[spec]++;
                    else
                        result.Add(spec, 1);
                }
            }


            return result.ToList().OrderByDescending(x => x.Value);
        }


        

        public IEnumerable<KeyValuePair<string, int>> getGNSDirectionNumbers(IEnumerable<Article> articles, int pairCount = 1)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();


            HashSet<string> resultSet = new HashSet<string>();
            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    set.Add(spec.Code);
                }
                if (set.Count != pairCount)
                    continue;

                var orderedList = set.ToList().OrderBy(x => x);

                var bufKey = String.Join(" И ", orderedList); //orderedList.First() + ".00.00 + orderedList.Last() + ".00.00";
                if (!result.Keys.ToList().Contains(bufKey))
                    result.Add(bufKey, 1);
                else
                    result[bufKey]++;

            }
            return result.ToList().OrderByDescending(x => x.Value);
        }



        public IEnumerable<KeyValuePair<string, int>> Plotnost(IEnumerable<Article> articles)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var el in articles)
            {
                

                var setNJ = new HashSet<string>();
                var setGNS = new HashSet<string>();
                foreach (var spec in el.scientificSpecialities)
                {
                    setGNS.Add(spec.Code);
                    setNJ.Add(spec.FirstCode.ToString()+"00.00");
                }

                var key = (setNJ.Count / (double)setGNS.Count).ToString();
                if (!result.Keys.Contains(key))
                    result.Add(key, 1);
                else
                    result[key]++;

            }
            return result.ToList().OrderBy(o=>o.Key);
        }



            // плотность чего то там TODO: доделать
            public IEnumerable<KeyValuePair<string, double>> getGNSOnDirectionDistribution(IEnumerable<Article> articles)
        {

            Dictionary<string, double> result = new Dictionary<string, double>();
            List<Dictionary<string, int>> ls = new List<Dictionary<string, int>>();

            foreach (var el in articles)
            {
                var set = new HashSet<string>();
                var currentList = new Dictionary<string, int>();

                foreach (var spec in el.scientificSpecialities)
                {
                    var specCode = spec.FirstCode.ToString()+".00.00";
                    if (currentList.Keys.ToList().Contains(specCode))
                        currentList[specCode]++;
                    else
                        currentList.Add(specCode, 1);
                }
                ls.Add(currentList);

            }
            Dictionary<string, double> r1 = new Dictionary<string, double>();
            foreach (var el in ls)
            {

            }



            //Dictionary<string, KeyValuePair<int,int>> res = new Dictionary<string, KeyValuePair<int, int>>();
            //foreach (var el in ls)
            //{
            //    foreach (var el2 in el)
            //    {
            //        if (res.Keys.ToList().Contains(el2.Key))
            //            res[el2.Key]++;
            //        else
            //            res.Add(el2.Key, new KeyValuePair<int, int>(1,el2.Value);


            //    }
            //}


            return result.ToList().OrderByDescending(x => x.Value);
        }

        public IEnumerable<KeyValuePair<string, int>> getGNS_NJ_ALL(IEnumerable<Article> articles)
        {
            

            Dictionary<string, int> result = new Dictionary<string, int>();

            result.Add("GNS", 0);
            result.Add("NJ", 0);
            result.Add("ALL", 0);

            foreach (var el in articles)
            {
                bool isNJ = false;
                bool isGNS = false;
                foreach (var spec in el.scientificSpecialities)
                {
                    if (spec.SecondCode != 0)
                        isGNS = true;
                    else
                        isNJ = true;
                }

                if (isNJ && isGNS)
                    result["ALL"]++;
                if (isNJ && !isGNS)
                    result["NJ"]++;
                if (isGNS && !isNJ)
                    result["GNS"]++;
            }


            return result.ToList().OrderByDescending(x => x.Value);
        }






    }
}
