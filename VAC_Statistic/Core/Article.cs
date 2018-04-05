using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VAC_Statistic.Core
{
    class Article
    {
        public string articleName;
        public string ISSN;
        public HashSet<Speciality> scientificSpecialities = new HashSet<Speciality>();

        public void addSpeciality(Speciality spec)
        {
            scientificSpecialities.Add(spec);
        }
        public void addSpeciality(string spec)
        {
            scientificSpecialities.Add(new Speciality(spec));
        }

    }
}
