using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionMenu
{
    public class Menu
    {
        private double prixEntree;
        private double prixPlatPrincipale;
        private double prixDessert;
        private string nomMenu;
        private string nomEntree;
        private string nomPlatPrincipale;
        private string nomDessert;

        public Menu()
        {
            prixEntree = 0;
            prixPlatPrincipale = 0;
            prixDessert = 0;
            nomMenu = "nassim";
            nomEntree = "nassim";
            nomPlatPrincipale = "nassim";
            nomDessert = "nassim";

        }
        public Menu(string nomMe)
        {
            prixEntree = 0;
            prixPlatPrincipale = 0;
            prixDessert = 0;
            nomMenu = nomMe;
            nomEntree = "nassim";
            nomPlatPrincipale = "nassim";
            nomDessert = "nassim";

        }
        public Menu(string nomMe, string nomEn, string nomPP, string nomDe, double pxEn, double pxPP, double pxDe)
        {
            nomMenu = nomMe;
            nomEntree = nomEn;
            nomPlatPrincipale = nomPP;
            nomDessert = nomDe;
            prixEntree = pxEn;
            prixPlatPrincipale = pxPP;
            prixDessert = pxDe;

        }
        public void setNomMenu(string nomMe)
        {
            nomMenu = nomMe;
        }
        public string getNomMenu()
        {
            return nomMenu;
        }
        public void setNomEntree(string nomEn)
        {
            nomEntree = nomEn;
        }
        public string getNomEntree()
        {
            return nomEntree;
        }
        public void setNomPlatPrincipale(string nomPP)
        {
            nomPlatPrincipale = nomPP;
        }
        public string getNomPlatPrincipale()
        {
            return nomPlatPrincipale;
        }
        public void setNomDessert(string nomDe)
        {
            nomDessert = nomDe;
        }
        public string getNomDessert()
        {
            return nomDessert;
        }
        public void setPrixEntree(double pxEn)
        {
            prixEntree = pxEn;
        }

        public void setPrixPlatPrincipale(double pxPP)
        {
            prixPlatPrincipale = pxPP;
        }

        public void setPrixDessert(double pxDe)
        {
            prixDessert = pxDe;
        }

        public void setLesPrix(double pxEn, double pxPP, double pxDe)
        {
            setPrixEntree(pxEn);
            setPrixPlatPrincipale(pxPP);
            setPrixDessert(pxDe);
        }
        public void setLesNoms(string nomMe, string nomEn, string nomPP, string nomDe)
        {
            setNomMenu(nomMe);
            setNomEntree(nomEn);
            setNomPlatPrincipale(nomPP);
            setNomDessert(nomDe);
        }
        public void setLesNoms(string nomEn, string nomPP, string nomDe)
        {
            setNomEntree(nomEn);
            setNomPlatPrincipale(nomPP);
            setNomDessert(nomDe);
        }
        public string getMenu()
        {
            return $"Menu :{nomMenu} \n \n Entrée :{nomEntree} \n Plat Principale :{nomPlatPrincipale} \n Dessert :{nomDessert}";
        }
        public double getprixMenu()
        {
            return prixEntree + prixPlatPrincipale + prixDessert;
        }
    }
}


