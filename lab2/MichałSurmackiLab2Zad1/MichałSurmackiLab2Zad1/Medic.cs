using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichałSurmackiLab2Zad1
{
    public class Medic : Unit
    {
        //Konstruktor klasy Medic
        public Medic()
        {
            this.attackPoints = 0;
            this.defencePoints = 100;
            this.healthPoints = 100;
        }

        /// <summary>
        /// Funkcja zliczająca żywe jednostki w liście units podawanej jako argument.
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        static public int CountDeadUnits(ref List<Medic> units)
        {
            int ans = 0;
            for (int i = units.Count - 1; i >= 0; i--)
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
            this.defencePoints = 100;
        }
    }
}
