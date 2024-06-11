using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Salutation_Git
{
    class Etudiant
    {
        private String idEt;

        public String IdEt
        {
            get { return idEt; }
            set { idEt = value; }
        }
        private String nom;

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public Etudiant()
        {
        }
    }
}
