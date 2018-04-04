using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAC_Statistic
{
    class Article
    {
        public string articleName;
        public string ISSN;
        HashSet<string> scientificSpecialities = new HashSet<string>();

        public void addSpeciality(string spec)
        {
            scientificSpecialities.Add(spec);
        }

    }
}
