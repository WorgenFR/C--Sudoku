using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sudoku.Model
{
    class InteractionLigneColonneBloc : RègleSudoku
    {
        public override bool Appliquer(Sudoku sudoku, out string description)
        {
            description = "";
            bool res = false;

            foreach (Ligne ligne in sudoku.Lignes)
            {
                foreach (Bloc bloc in sudoku.Blocs)
                {
                    Groupe inter = ligne * bloc;
                    if (inter.Count == 0) continue;

                }
            }

            return res;
        }
    }
}
