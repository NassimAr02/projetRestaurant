using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionMenu;
using gestionClient;
using gestionClientFidele;


namespace restaurant_ARRASS
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mnuEco = new Menu("Menu Économique", "Salade Verte", "Steak Haché", "Pomme", 3, 6, 2);

            Menu mnuClass = new Menu("Menu Classique");
            mnuClass.setNomEntree("Rillette de la mer");
            mnuClass.setNomPlatPrincipale("Steack Frites");
            mnuClass.setNomDessert("Boule de glace");
            mnuClass.setPrixEntree(5);
            mnuClass.setPrixPlatPrincipale(8);
            mnuClass.setPrixDessert(4);
            Menu mnuGastro = new Menu();
            mnuGastro.setLesPrix(8, 12, 6);
            mnuGastro.setLesNoms("Menu gastronomique", "Meli-mélo", "Croustade de la mer", "Sabayon aux fruits des bois");
            Console.WriteLine(mnuEco.getMenu());
            Console.WriteLine("\n le prix du menu est de " + mnuEco.getprixMenu() + " Euros");
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Console.WriteLine(mnuClass.getMenu());
            Console.WriteLine("\n le prix du menu est de " + mnuClass.getprixMenu() + " Euros");
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Console.WriteLine(mnuGastro.getMenu());
            Console.WriteLine("\n le  prix du menu est de " + mnuGastro.getprixMenu() + " Euros");
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Client clt1 = new Client();
            clt1.setInfoClient(1, "Dupont", "Pierre", "4 rue des pieds");
            clt1.mange(mnuEco);
            //Console.WriteLine(clt1.getNumeroClient());
            Console.WriteLine("les informations du client :\n");
            Console.WriteLine(clt1.getInfoClient());
            //Console.WriteLine("Le montant à régler pour le Menu économique : ");
            //Console.WriteLine(clt1.getPrixMenuClient() + "\n");
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Client clt2 = new Client();
            clt2.setInfoClient(2, "Wecker", "Thierry", "2 rue de l'Eglise Strasbourg");
            clt2.mange(mnuClass);
            //Console.WriteLine(clt2.getNumeroClient());
            Console.WriteLine("les informations du client :\n");
            Console.WriteLine(clt2.getInfoClient());
            //Console.WriteLine("Le montant à régler pour le Menu gastronomique : ");
            //Console.WriteLine(clt2.getPrixMenuClient() + "\n");
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Client clt3 = new Client();
            clt3.setInfoClient(3, "Sayn", "Mehmet", "27 rue de la Marne Strasbourg");
            clt3.mange(mnuGastro);
            //Console.WriteLine(clt3.getNumeroClient());
            Console.WriteLine("les informations du client :\n");
            Console.WriteLine(clt3.getInfoClient());
            //Console.WriteLine("Le montant à régler pour le Menu classique : ");
            //Console.WriteLine(clt3.getPrixMenuClient() + "\n");
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Client clt4 = new Client();
            clt4.setInfoClient(4, "Demetz", "Stéphanie", "4 avenue de l'opéra Mulhouse");
            clt4.mange(mnuEco);
            //Console.WriteLine(clt4.getNumeroClient());
            Console.WriteLine("les informations du client :\n");
            Console.WriteLine(clt4.getInfoClient());
            //Console.WriteLine("Le montant à régler pour le Menu économique : ");
            //Console.WriteLine(clt4.getPrixMenuClient());
            Console.WriteLine("appuyez sur une touche pour continuer...");
            Console.ReadKey();
            Console.WriteLine(clt1.getNomClient() + " avec une addition de : " + clt1.Addition());
            Console.WriteLine(clt2.getNomClient() + " avec une addition de : " + clt2.Addition());
            Console.WriteLine(clt3.getNomClient() + " avec une addition de : " + clt3.Addition());
            Console.WriteLine(clt4.getNomClient() + " avec une addition de : " + clt4.Addition() + "\n\n\n");
            Client clt5 = new Client();
            clt5.setNumeroClient(5);
            clt5.setNomClient("ARRASS");
            clt5.setPrenomClient("Nassim");
            clt5.setAdresseClient("1 rue Marcel Pagnol Oberhausbergen");
            clt5.rajouteMenu(mnuEco);
            clt5.rajouteMenu(mnuEco);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuGastro);
            clt5.rajouteMenu(mnuClass);
            //Console.WriteLine(clt5.getNumeroClient());
            //Console.WriteLine(clt5.getInfoClient());

            Console.WriteLine(clt5.getNomClient()+ " avec une addition de : " +clt5.AdditionTable());
            Console.WriteLine(clt5.getNomClient() + " avec une addition  réduite (15) de : " + clt5.AdditionReduc());
            Console.WriteLine("appuyez sur une touche pour continuer...");
            ClientFidele clientfid1 = new ClientFidele(6,"Clientfid","Ahmed","1 rue du client fidèle");
            clientfid1.mange(mnuGastro);
            
            Console.WriteLine(clientfid1.getNomClient() + " avec une addition réduite de " + clientfid1.Addition());
            ClientFidele clientfid2 = new ClientFidele(7,"ARRASS","Nassim","1 rue Marcel Pagnol Oberhausbergen",0.25);
            clientfid2.mange(mnuClass);
            Console.WriteLine(clientfid2.getNomClient() + " avec une addition réduite de " + clientfid2.Addition(clientfid2,0.25));
            Console.ReadKey();
            

        }
    }
}