namespace ServoxClass
{
    internal class Program
    {
        public static int  EstConnecte(List<Employe> employes,string codeDacces)
        {
            foreach (var employe in employes)
            {
                if (codeDacces == employe.codeDacces)
                { return employes.IndexOf(employe); }
            }
            return -1;
        }
       
        static void Main(string[] args)
        {
            List<string> nosCodesDacces = new List<string> { "123", "245", "567" };
            List<string> nosCles = new List<string> { "14", "28", "35" };
            List<string> nosTeleavertisseurs = new List<string> { "418666", "265788", "27564" };
            List<Employe> employeConnecte = new List<Employe>();
            string code, cles, badget;
            int entree=0,choix=0;
           
            
            
                do
                {
                    Console.WriteLine(@"Bienvenue sur servox desinfection!
                                  veuillez entrer votre code d'acces");
                    code = Console.ReadLine();

                if (nosCodesDacces.IndexOf(code) != -1)

                {
                    
                        if (EstConnecte(employeConnecte, code) == -1)
                        {
                            Console.WriteLine("vous etes presentement absent de la liste pour indiquer votre entree appuyer sur 1");
                        try { entree = int.Parse(Console.ReadLine()); }
                        catch 
                        { 
                          Console.WriteLine("vous devez saisir un entier");
                        }
                            if (entree == 1)
                            {
                                Console.WriteLine("veuillez entrer votre numero de teleavertisseur");
                                badget = Console.ReadLine();
                                if (nosTeleavertisseurs.IndexOf(badget) != -1)
                                {
                                    Console.WriteLine("veuillez entrer votre numero de groupe de chambre");
                                    cles = Console.ReadLine();
                                    if (nosCles.IndexOf(cles) != -1)
                                    {
                                        Employe monEmploye = new Employe(code, cles, badget);
                                        monEmploye.SeConnecte(employeConnecte);
                                    }
                                    else
                                    {
                                    Console.WriteLine("cette cle n'existe pas");
                                    }
                                }
                                else
                                {
                                Console.WriteLine("Desole!ce numero de teleavertisseur n'existe pas");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("vous etes presentement inscrit dans la liste pour indiquer votre sortie appuyer sur 2");
                        try { entree = int.Parse(Console.ReadLine()); }
                        catch
                        {
                            Console.WriteLine("vous devez saisir un entier");
                        }
                        if (entree == 2)
                            {
                                var i = EstConnecte(employeConnecte, code);
                                employeConnecte[i].SeDeconnecte(employeConnecte);
                            }
                            /*lire la sortie,reecrire la methode qui deconnecte l'employe,boucler tout ca dans un do while,
                             * sans oublier afficher les mployes inscrits*/
                        }
                    }


                else
                    {
                        Console.WriteLine("Desole ce code d'acces n'est pas correct");
                    }
                    Console.WriteLine(@"Voulez vous sortir de servox
                                      1-oui
                                       2-non");
                try { choix = int.Parse(Console.ReadLine()); }
                catch
                {
                    Console.WriteLine("vous devez saisir un entier");
                }

            } while (choix == 2);
            
            


           

        }
        
       
    }
}