using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichałSurmackiLab2Zad1
{
    public class FootWarrior : Unit
    {
        //Konstruktor klasy FootWarrior
        public FootWarrior()
        {
            this.attackPoints = 50;
            this.defencePoints = 50;
            this.healthPoints = 100;
        }
        
        /// <summary>
        /// Funkcja zliczająca zabite jednostki.
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        static public int CountDeadUnits(ref List<FootWarrior> units)
        {
            int ans = 0;
            for (int i=units.Count-1; i>=0; i--)
            {
                if (!units[i].GetAliveStatment())
                {
                    ans++;
                    units.RemoveAt(i);
                }

            }
            return ans;
        }

        /// <summary>
        /// Funckja lecząca jednostkę do jej początkowych parametrów
        /// </summary>
        public void Heal()
        {
            this.healthPoints = 100;
        }

        /// <summary>
        /// Funckja przywracająca punty obrony jednostki
        /// </summary>
        public void Rest()
        {
            this.defencePoints = 50;
        }
    }
}
