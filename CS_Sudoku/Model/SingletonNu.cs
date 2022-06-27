using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sudoku.Model
{
    public class SingletonNu : RègleGroupe
    {
        public override bool Appliquer(Groupe groupe, out string description)
        {
            description = "";
            bool res = false;
            foreach (Cellule c in groupe)
            {
                if (!c.Trouvé && !c.Fixé && c.Possibilités.Count == 1)
                {
                    c.ModifierValeur(c.Possibilités.First());
                }
                if (c.Fixé || c.Trouvé)
                {
                    if (groupe.SupprimerPossibilité(c.Valeur, c))
                    {
                        res = true;
                        description += $"Singleton nu : La cellule {c.Nom}"+ $" ne contient que {c.Valeur} dans le groupe"+ $"{grouê.Nom}, {c.Valeur} est supprimé du reste du groupe\n";
                        if (this.ModePasAPas) return true;

                    }
                }
            }

            return res;
        }
    }
}
