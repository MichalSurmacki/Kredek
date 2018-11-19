using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichałSurmackiLab2Zad1
{
    public class Unit
    {
        //zmienna przechowywująca punkty ataku jednostki.
        protected int attackPoints;
        //zmienna przechowywująca punkty obrony jednostki.
        protected int defencePoints;
        //zmienna przechowywująca punkty zdrowia jednostki.
        protected int healthPoints;
        //zmienna przechowywująca informacje czy dana jednostka jest żywa.
        Boolean alive = true;

        /// <summary>
        /// Funkcja odpowiedzialna za przyjmowanie obrażeń przez jednostkę. Modyfikuje wartości zmiennych punktów życia ect.
        /// </summary>
        /// <param name="damage"></param>
        public void TakeAHit(int damage)
        {
            this.defencePoints -= damage;
            if(defencePoints < 0)
            {
                healthPoints -= 50;
                if(healthPoints <= 0)
                {
                    this.attackPoints = 0;
                    this.defencePoints = 0;
                    this.healthPoints = 0;
                    alive = false;
                }
            }
        }

        /// <summary>
        /// Funkcja odpowiedzialna za leczenie jednostki. Dodaje wartości do zmiennej zawierającej punkty życia.
        /// </summary>
        /// <param name="points"></param>
        public void Heal(int points)
        {
            this.healthPoints += points;
        }

        /// <summary>
        /// Funkcja zwracająca wartość punktów ataku jednostki.
        /// </summary>
        /// <returns></returns>
        public int GetArrackPoints()
        {
            return attackPoints;
        }

        /// <summary>
        /// Funkcja zwracająca wartość zmiennej przechowywującej stan punktów zdrowia jednostki.
        /// </summary>
        /// <returns></returns>
        public int GetHealthPoints()
        {
            return healthPoints;
        }

        /// <summary>
        /// Funkcja zwracająca wartość zmiennej przechowywującej stan punktów obrony jednostki
        /// </summary>
        /// <returns></returns>
        public int GetDefencePoints()
        {
            return defencePoints;
        }

        /// <summary>
        /// Funkcja zwracająca informacje o ty czy jednostka żyje
        /// </summary>
        /// <returns></returns>
        public Boolean GetAliveStatment()
        {
            return alive;
        }
    }
}
