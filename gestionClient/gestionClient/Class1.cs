using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestionMenu;
using gestionClientFidele;


namespace gestionClient
{
    public class Client
    {
        private int numeroClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;
        private Menu mnu;
        private Menu[] tableClient = new Menu[10];
        private int nbreMenu = 1;
        private double montantAddition;
        
        public Client()
        {
            numeroClient = 0;
            nomClient = "nassim";
            prenomClient = "nassim";
            adresseClient = " ";
            mnu = new Menu();

        }
        public Client(int numCli)
        {
            numeroClient = numCli;
            nomClient = "nassim";
            prenomClient = "nassim";
            adresseClient = " ";
            mnu = new Menu();
        }
        public Client(int numCli, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = " ";
            mnu = new Menu();
        }
        public Client(int numCli, string nomCli, string prenomCli, string adresseCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = adresseCli;
            montantAddition = 0;
            mnu = new Menu();

        }
        
        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }
        public int getNumeroClient()
        {
            return numeroClient;
        }
        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }
        public string getNomClient()
        {
            return nomClient;
        }
        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }
        public string getPrenomClient()
        {
            return prenomClient;
        }
        public void setAdresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }
        public string getAdresseClient()
        {
            return adresseClient;
        }

        public void setInfoClient(int numCli, string nomCli, string prenomCli, string adresseCli) // mutateur ou setteur
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = adresseCli;
        }

        public string getInfoClient() // accesseur ou getteur 
        {
            return $"Information du client : \n \n Nom : {nomClient} \n Prenom :{prenomClient} \n adresse :{adresseClient}";
        }

        public void mange(Menu unMenu)
        {
            mnu = unMenu;
        }

        public Menu GetMenu()
        {
            return mnu;
        }
        public double Addition()
        {
            return mnu.getprixMenu();
        }
        public void rajouteMenu(Menu unMenu)
        {
            tableClient[nbreMenu] = unMenu;
            nbreMenu += 1;
        }
        public double AdditionTable()
        {
            int i;
            for (i = 1; i < 8; i++)
            {
                montantAddition += tableClient[i].getprixMenu();
            }
            return montantAddition;
            
        }
        public double AdditionReduc()
        {
            return montantAddition *= 0.85;
        } 

    }


}
