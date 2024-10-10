using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gestionClientFidele
{
    public class ClientFidele : Client
    {
        private double redFidelite;
        private double additionClient;

        public ClientFidele(int numCli, string nomCli, string prenomCli, string adresseCli) : base(numCli, nomCli, prenomCli, adresseCli)
        {
            this.redFidelite = 0.1;
        }

        public ClientFidele(int numCli, string nomCli, string prenomCli, string adresseCli, double reduc) : base(numCli, nomCli, prenomCli, adresseCli)
        {
            
            this.redFidelite = reduc;
        }
        
        public new double Addition(int supplementaire)
        {
            double prix = base.Addition(10);
            double res = prix * ((100-double.Parse(supplementaire.ToString)))
            return res
        }

        // Méthode pour calculer l'addition avec une réduction spécifique
        public double Addition(ClientFidele unClient, double reduc)
        {
            double totalAddition = unClient.Addition(); // Appelle la méthode de base pour obtenir l'addition
            return totalAddition * (1 - reduc); // Applique la réduction spécifique
        }
    }
}
