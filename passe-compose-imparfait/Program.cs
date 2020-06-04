using System;

namespace passe_compose_imparfait {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Est-ce qu'on utilise le Passe Compose ou l'imparfait?");
            Console.WriteLine("Taper O");


            string choice = "O";




            while (choice.Contains("o") || choice.Contains("O")) {
                choice = Console.ReadLine();
                

                while (choice.Contains("n") || choice.Contains("N")) {
                    choice = Console.ReadLine();
                    Console.WriteLine("Utilisez l'imparfait.");
                }

                
                Console.WriteLine("Est ce que l'action terminee dans le passe?");
                if (choice.Equals("O")) {
                    Console.WriteLine("Utilisez le passe compose");
                } else if (choice.Equals("N")) {
                    Console.WriteLine("Est ce qu'on utilise le si conditionnel?");
                } else if (choice.Equals("O")) {
                    Console.WriteLine("Utilisez le passe compose");
                } else if (choice.Equals("N")) {
                    Console.WriteLine("Est-ce que l'action terminee dans un espace de temps qui n'est pas encore achevee?");
                } else if (choice.Equals("O")) {
                    Console.WriteLine("Utilisez le passe compose");
                } else if (choice.Equals("N")) {
                    Console.WriteLine("Est ce que l'action se produit pendant une periode de temps bien definie?");
                } else if (choice.Equals("O")) {
                    Console.WriteLine("Utilisez le passe compose");
                }
                /*else (choice.Equals("N")){


                   Console.WriteLine("Utilisez l'imparfait");
               }*/




                choice = Console.ReadLine();
                Console.WriteLine("Utilisez le passe compose.");
                Console.WriteLine("Continuez?");
                Console.ReadKey();
            }
            
            Console.WriteLine();
                Console.WriteLine("=========");
                Console.WriteLine("Au Revoir");
            }
        }
    }

  

