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
        public static string beautifulResult(List<List<double>> values)
        {
            string ans = "";
            
            foreach (var el in values)
            {
                ans += String.Join("\t", el);
                ans += "\r\n";
            }
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


            return result
                    .ToList()
                    .OrderByDescending(x => x.Value);
        }


        public IEnumerable<KeyValuePair<string, int>> getWitoutTechnicalSpecs(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var link  = articles.Where(x => x.scientificSpecialities.All(o => !o.IsTechnical));
            result.Add("asbsoletely", link.Count());
            result.Add("percent", Convert.ToInt16(((double)link.Count() / articles.Count())*100) );
            return result.ToList();
        }

        public IEnumerable<KeyValuePair<string, int>> getWithTechnicalSpecsOnly(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var link = articles.Where(x => x.scientificSpecialities.All(o => o.IsTechnical) && x.scientificSpecialities.Any(o=>o.IsTechnicalOnly) );
                
            result.Add("asbsoletely", link.Count());
            result.Add("percent", Convert.ToInt16(((double)link.Count() / articles.Count()) * 100));
            return result.ToList();
        }
        public IEnumerable<KeyValuePair<string, int>> getWithTechnicalAndNotTechnicalSpecs(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var link = articles.Where(x => x.scientificSpecialities.Any(o => o.IsTechnical) && x.scientificSpecialities.Any(o=> !o.IsTechnical));
            result.Add("asbsoletely", link.Count());
            result.Add("percent", Convert.ToInt16(((double)link.Count() / articles.Count()) * 100));
            return result.ToList();
        }


        public IEnumerable<KeyValuePair<string, int>> getTnWithPhysic(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var link = articles.Where(x => x.scientificSpecialities.All(o=> o.IsTechnical) && x.scientificSpecialities.Any(o=> o.IsPhysicalOnly));
            result.Add("asbsoletely", link.Count());
            result.Add("percent", Convert.ToInt16(((double)link.Count() / articles.Count()) * 100));
            return result.ToList();
        }
        public IEnumerable<KeyValuePair<string, int>> getTnWithoutPhysic(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var link = articles.Where(x => x.scientificSpecialities.All(o => o.IsTechnicalOnly));
            result.Add("asbsoletely", link.Count());
            result.Add("percent", Convert.ToInt16(((double)link.Count() / articles.Count()) * 100));
            return result.ToList();
        }

        public IEnumerable<KeyValuePair<string, int>> getNS_TN_FMI(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            Dictionary<string, int> specs = new Dictionary<string, int>();

            foreach (var el in articles)
            {
                foreach (var spec in el.scientificSpecialities)
                {
                    if (!specs.Keys.Contains(spec.Code))
                        specs.Add(spec.Code, -100);

                    if (!spec.IsTechnical)
                        specs[spec.Code] = Math.Max(specs[spec.Code], -100);
                    if (spec.IsTechnicalOnly) {
                        if (specs[spec.Code] == 2)
                            specs[spec.Code] = 3;
                        specs[spec.Code] = Math.Max(specs[spec.Code], 1);
                        
                    }
                    if (spec.IsPhysicalOnly)
                        if (specs[spec.Code] == 1)
                            specs[spec.Code] = 3;
                        specs[spec.Code] = Math.Max(specs[spec.Code], 2);
                }
            }


            var together = specs.Where(x => x.Value == 3).Count();
            var tech = specs.Where(x => x.Value == 1).Count();
            var phys = specs.Where(x => x.Value == 2).Count();

            result.Add("только технические НС ", tech);
            result.Add("только ФМИ НС ", phys);
            result.Add("ТН и ФМИ НС: ", together);

            return result.ToList();
        }

        public IEnumerable<KeyValuePair<string, int>> getNSCount(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 1; i < 40+1; i++)
            {
                var articlesCount = articles.Where(x =>x.scientificSpecialities.All(o=>o.IsTechnical) && x.scientificSpecialities.Count == i).ToList();
                result.Add(i.ToString(), articlesCount.Count());
            }
            return result.ToList();
        }


        public IEnumerable<KeyValuePair<string, int>> getNSTechDistribution(IEnumerable<Article> articles)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            var ThirdGroup = articles.Where(x => x.scientificSpecialities.Any(o => o.IsTechnical) && x.scientificSpecialities.Any(o => !o.IsTechnical))
               // .Union(articles.Where(x => x.scientificSpecialities.All(o => o.IsTechnical) && x.scientificSpecialities.Any(o => o.IsTechnicalOnly)))
                .ToList();
            int countLess20 = ThirdGroup.Where(x => ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) < 0.2).Count();
            result.Add("0 - 20 % => ", countLess20);
            int countLess40 = ThirdGroup.Where(x => ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) < 0.4 && ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) >= 0.2).Count();
            result.Add("20-40 % =>", countLess40);
            int countLess60 = ThirdGroup.Where(x => ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) < 0.6 && ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) >= 0.4).Count();
            result.Add("40-60 % =>", countLess60);
            int countLess80 = ThirdGroup.Where(x => ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) < 0.8 && ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) >= 0.6).Count();
            result.Add("60-80 % =>", countLess80);
            int countLess100 = ThirdGroup.Where(x => ((double)x.scientificSpecialities.Where(o => o.IsTechnical).Count()) / ((double)x.scientificSpecialities.Count) >= 0.8 ).Count();
            result.Add("80 % < =>", countLess100);

            return result.ToList();
        }

        public IEnumerable<KeyValuePair<string, int>> getNSTechDistribForEach(IEnumerable<Article> articles)
        {
            Dictionary<string, int> specs = new Dictionary<string, int>();

            foreach (var el in articles)
            {
                foreach (var spec in el.scientificSpecialities)
                {
                    if (spec.FirstCode != 5)
                        continue;
                    if (!specs.Keys.Contains(spec.Code))
                        specs.Add(spec.Code, 0);
                    specs[spec.Code] = specs[spec.Code] + 1;
                }
            }
            return specs.ToList().OrderBy(x => x.Key).ToList(); 
        }


        public List<List<double>> listFrequencySpecs(IEnumerable<Article> articles, int firstCode = 05, int secondCode = 02)
        {
            int asb = 0;
            var _listSpecs = new List<int>();
            foreach (var el in articles)
            {
                foreach (var spec in el.scientificSpecialities)
                {
                    if(spec.FirstCode == firstCode && spec.SecondCode == secondCode) { 
                        _listSpecs.Add(spec.ThirdCode);
                        if (spec.ThirdCode == 18)
                            asb++;
                    }

                }
            }
            

            var listSpecs = _listSpecs.Distinct().OrderBy(x=> x).ToList();

            var result = new List<List<double>>();

            for (int i = 0; i < listSpecs.Count(); i++)
            {
                result.Add(new List<double>());

                for (int j = 0; j < listSpecs.Count(); j++)
                {
                    result[i].Add(0);

                    double ans = 0.0;
                    if( i != j )
                    {
                        int allCounter = articles.Where(x => x
                                                    .scientificSpecialities
                                                    .Any(o => o.ThirdCode == listSpecs[i])
                                                    && x
                                                    .scientificSpecialities
                                                    .Any(o => o.ThirdCode == listSpecs[j])
                                                    ).Count();
                        int firstCounter = articles.Where(x => x.scientificSpecialities.Any(o => o.ThirdCode == listSpecs[i])).Count();
                        int secondCounter = articles.Where(x => x.scientificSpecialities.Any(o => o.ThirdCode == listSpecs[j])).Count();
                        double res = allCounter / ((firstCounter + secondCounter) / 2.0);
                        res = res * 100; // percents
                        ans = res;

                    }
                    result[i][j] = Math.Round(ans,2);
                }
            }


            return result;
        }

        public double difValue(List<List<double>> values)
        {
            double RSum = 0;
            double oneSum = 0;
            for (int i = 0; i < values.Count(); i++)
            {
                for (int j = i+1; j < values.Count(); j++)
                {
                    oneSum++;
                    RSum += values[i][j] / 100.0;
                }
            }

            double res = (1 - (RSum * oneSum))*100;


            return res;
        }
    }
}
