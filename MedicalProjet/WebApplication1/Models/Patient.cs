using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet.Models
{
    public class Patient : Utilisateur
    {
        public int Id { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}
