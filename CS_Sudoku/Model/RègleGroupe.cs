using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Sudoku.Model
{
    public abstract class RègleGroupe : RègleSudoku
    {
        public override bool Appliquer(Sudoku sudoku, out string description)
        {
            this.Sudoku = sudoku;
            foreach (Groupe g in sudoku.Groupes)
            {
                if (this.Appliquer(g, out string d))
                {

                }
            }
        }

        public abstract bool Appliquer(Groupe groupe, out string description);
    }
}
