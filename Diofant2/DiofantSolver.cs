using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diofant2
{
    internal class DiofantSolver
    {
        int ACoef, BCoef, CCoef;
        List<int> XSolves = new List<int>();
        List<int> YSolves = new List<int>();

        public bool SetCoefficients(
            string a,
            string b,
            string c
        )
        {
            bool temp = 
                Int32.TryParse(a, out ACoef) &&
                Int32.TryParse(b, out BCoef) &&
                Int32.TryParse(c, out CCoef)
            ;

            // Cant parse numbers
            if (!temp) return false;

            // Cant solve for negative numbers
            if (!(ACoef > 0 && BCoef > 0 && CCoef > 0)) return false;

            return true;
        }

        /**
         * Euqlide algorithm.
         */
        public static int GCD (int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return Math.Abs(a);
        }

        public void Solve()
        {
            int aGCD = GCD(ACoef, CCoef);
            int bGCD = GCD(BCoef, CCoef);

            // Clear previous solves
            // Здесь у оригинальной программы баг: если решить второе уравнение, у которого решений меньше,
            // чем у первого, то останутся ответы от первого.
            XSolves.Clear();
            YSolves.Clear();

            for (int i = 0; i <= CCoef / ACoef; i++)
            {
                for(int j = 0; j <= CCoef / BCoef; j++)
                {
                    if (ACoef / aGCD * i + BCoef / bGCD * j == CCoef / (aGCD * bGCD))
                    {
                        XSolves.Add(i * bGCD);
                        YSolves.Add(j * aGCD);
                    }
                }
            }
        }

        /**
         * Display diofan equesion solves in data grid view.
         */
        public void ShowResult(DataGridView gridSolves)
        {
            gridSolves.RowCount = XSolves.Count; // Extend data grid view.
            for (int i = 0; i < XSolves.Count; i++) {
                gridSolves.Rows[i].Cells[0].Value = XSolves[i];
                gridSolves.Rows[i].Cells[1].Value = YSolves[i];
             }
        }
    }
}
