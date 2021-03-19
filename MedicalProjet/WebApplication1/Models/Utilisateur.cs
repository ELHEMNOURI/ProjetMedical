using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.Models
{
    public abstract class Utilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Age { get; set; }
        public string Adresse { get; set; }
        public int Tel { get; set; }
    }
}
