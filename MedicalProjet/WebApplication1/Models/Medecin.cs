using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.Models
{
    
    public class Medecin : Utilisateur
    {
        public int Id { get; set; }
        public  string CodeCnam { get; set; }
        public string Specialite { get; set; }
        public string Experience { get; set; }
        public string Universite { get; set; }
        public Boolean Disponibilite { get; set; }
    }
}
