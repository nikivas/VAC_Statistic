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
        public string _Name = "";
        public string ISSN;
        public HashSet<Speciality> scientificSpecialities = new HashSet<Speciality>();
        public int dateCounterHelper = 0;
        private HashSet<Speciality> _bufferedSpecs = new HashSet<Speciality>();

        public void addSpeciality(Speciality spec)
        {
            if(dateCounterHelper < 1)
                scientificSpecialities.Add(spec);
            else if(dateCounterHelper == 1)
                _bufferedSpecs.Add(spec);

        }

        public void addName(string name)
        {
            this._Name += name;
        }

        public void finallyzeSpec()
        {
            if(dateCounterHelper == 1 && _bufferedSpecs.Count > 0)
            {
                foreach (var el in _bufferedSpecs)
                {
                    scientificSpecialities.Add(el);
                }
            }
            
        }
        public void addSpeciality(string spec)
        {
            scientificSpecialities.Add(new Speciality(spec));
        }

    }
}
