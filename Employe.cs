using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ServoxClass
{
    public class Employe
    {
        public string? codeDacces {  get; set; }
        public string? cles { get; set; }
        public string? teleAvertisseur { get; set; }
        public Employe(string CodeDacces,string Cles,string TeleAvertisseur)
        {
            codeDacces = CodeDacces; 
             cles= Cles;
            teleAvertisseur = TeleAvertisseur;
        }
       
        public  void SeConnecte(List<Employe> employes)
        {
            employes.Add(this);
            Console.WriteLine("votre nom a ete ajoute dans la liste");
        }
        public void SeDeconnecte(List<Employe> employes)
        {
            employes.Remove(this);
            Console.WriteLine("votre nom a ete supprime de la liste,Aurevoir");
        }


    }
}
