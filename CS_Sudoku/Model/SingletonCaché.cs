using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sudoku.Model
{
    public class SingletonCaché : RègleGroupe
    {
        public override bool Appliquer(Groupe groupe, out string description)
        {
            description = "";
            bool res = false;

            for (int c=1; c<=9; c++)
            {
                if (!groupe.ContientValeurFixéeOuTrouvée(c))
                {
                    Groupe g = groupe.GetCellulesContenantAuMoins(c);
                    if (g.Count == 1)
                    {
                        if (g.First().SupprimerExcepté(c))
                        {
                            description += $"Singleton caché : Le groupe {groupe.Nom} ne"
                                + $"contient qu'un seul {c} qui se trouve dans la cellule {}"
                                + "les autres possibilités de cette cellule sont supprimées";
                            res = true;
                            if (this.ModePasAPas) return true;
                        }
                    }

                }
            }

            return res;
        }
    }
}
