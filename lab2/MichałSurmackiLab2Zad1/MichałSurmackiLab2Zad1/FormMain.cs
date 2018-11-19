using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//wyszło spaghetti ale nie ma czasu żeby to naprawić :/ funkcje związane z walką można zamiast kopiować zaimplementować inaczej np. jako osobne funkcje w innej klasie. dodać klasy Computer i Player przechowywujące dane na temat jednostek itd.

namespace MichałSurmackiLab2Zad1
{
    public partial class FormMain : Form
    {
        //zmienna przechowywujaca liste piechurów gracza
        List<FootWarrior> playerFootWarriors;
        //zmienna przechowywujaca liste jazdy konnej gracza
        List<HorseWarrior> playerHorseWarriors;
        //zmienna przechowywujaca liste najemników gracza
        List<SoldierOfFortune> playerSoldiersOfFortune;
        //zmienna przechowywująca liste medyków gracza
        List<Medic> playerMedics;
        //zmienna przechowywująca liste skarbników gracza
        List<Treasurer> playerTreasurers;
        //zmienna przechowywująca liste umocnień gracza
        List<Defence> playerDefences;

        //zmienna przechowywujaca liste piechurów komputera
        List<FootWarrior> computerFootWarriors;
        //zmienna przechowywujaca liste jazdy konnej komputera
        List<HorseWarrior> computerHorseWarriors;
        //zmienna przechowywujaca liste najemników komputera
        List<SoldierOfFortune> computerSoldiersOfFortune;
        //zmienna przechowywująca liste medyków komputera
        List<Medic> computerMedics;
        //zmienna przechowywująca liste skarbników komputera
        List<Treasurer> computerTreasurers;
        //zmienna przechowywująca liste umocnień komputera
        List<Defence> computerDefences;

        //zmienna przechowywujaca punkty zdrowia gracza
        private int playersHP = 150;
        //zmienna przechowywujaca punkty zdrowia komputera
        private int computersHP = 150;
        //zmienna przechowywujaca wartosc pieniedzy gracza
        private int playersMoney = 0;
        //zmienna przechowywująca wartość pieniędzy komputera
        private int computersMoney = 0;
        //zmienna przechowywujaca wartosc przychodu gracza
        private int numberOfIncomeMoney = 100;
        //zmienna przechowywująca wartość przychodu komputera
        private int numberOfIncomeMoneyComputer = 150;

        /// <summary>
        /// Konstruktor głównego okna
        /// </summary>
        public FormMain()
        {
            //inicjalizacja zmiennych list, początkowych wartości etc.
            playerFootWarriors = new List<FootWarrior>();
            //dodanie do listy jednostek gracza FootWarrior 10 piechurów
            for (int i=0; i<10; i++)
            {
                playerFootWarriors.Add(new FootWarrior());
            }
            playerHorseWarriors = new List<HorseWarrior>();
            //dodanie do listy jednostek gracza HorseWarrior 10 konnych
            for (int i=0; i<10; i++)
            {
                playerHorseWarriors.Add(new HorseWarrior());
            }
            playerSoldiersOfFortune = new List<SoldierOfFortune>();
            playerMedics = new List<Medic>();
            playerTreasurers = new List<Treasurer>();
            //dodanie do listy jednostek gracza Treasurer 1 skarbnika
            playerTreasurers.Add(new Treasurer());
            playerDefences = new List<Defence>();

            computerFootWarriors = new List<FootWarrior>();
            //dodanie do listy jednostek komputera FootWarrior 15 piechurów
            for (int i=0; i<15; i++)
            {
                computerFootWarriors.Add(new FootWarrior());
            }
            computerHorseWarriors = new List<HorseWarrior>();
            //dodanie do listy jednostek komputera HorseWarrior 10 konnych
            for (int i=0; i<10; i++)
            {
                computerHorseWarriors.Add(new HorseWarrior());
            }
            computerSoldiersOfFortune = new List<SoldierOfFortune>();
            computerMedics = new List<Medic>();
            computerTreasurers = new List<Treasurer>();
            //dodanie do listy koputera 1 skarbnika
            computerTreasurers.Add(new Treasurer());
            computerDefences = new List<Defence>();

            InitializeComponent();
            //start timera odpowiedzialnego za dodawanie złota do zasobów gracza
            timerMoney.Start();
            //start timera odpowiedzialnego za atak komputera na gracza
            timerComputerAttack.Start();
            //start timera odpowiedzialnego za odświerzanie labeli textboxów ect.
            timerRefresh.Start();
            //start timera odpowiedzialnygo za kupowanie jednostek przez komputer
            timerComputerBuyingUnits.Start();
            //start timera odpowiedzialnego za dodawanie złota do zasobów komputera
            timerComputerMoney.Start();
            //ustawienie wartości początkowej HP gracza i komputera
            progressBarPlayerHP.Value = 100;
            progressBarComputerHP.Value = 100;
        }

        /// <summary>
        /// Przycisk odpowiedzialny za kupowanie jednostek - FootWarrior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFootWarrior_Click(object sender, EventArgs e)
        {
            int cost = Int32.Parse(labelFootWarriorCostValue.Text);
            if (playersMoney >= cost)
            {
                //odjęcie odpowiedniej ilości środków
                playersMoney -= cost;
                labelMoneyValue.Text = playersMoney.ToString();
                //dodanie nowej jednostki
                playerFootWarriors.Add(new FootWarrior());
                int x = Int32.Parse(labelAmountOfFootWarriorsValue.Text);
                x++;
                labelAmountOfFootWarriorsValue.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiedniej ilości złota.", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za kupowanie jednostek - HorseWarrior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyHorseWarrior_Click(object sender, EventArgs e)
        {
            int cost = Int32.Parse(labelHorseWarriorCostValue.Text);
            if (playersMoney >= cost)
            {
                //odjęcie odpowiedniej ilości środków
                playersMoney -= cost;
                labelMoneyValue.Text = playersMoney.ToString();
                //dodanie nowej jednostki
                playerHorseWarriors.Add(new HorseWarrior());
                int x = Int32.Parse(labelAmountOfHorseWarriorsValue.Text);
                x++;
                labelAmountOfHorseWarriorsValue.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiedniej ilości złota.", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za kupowanie jednostek - SoldierOfFortune
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuySoldierOfFortune_Click(object sender, EventArgs e)
        {
            int cost = Int32.Parse(labelSoldierOfFortuneCostValue.Text);
            if (playersMoney >= cost)
            {
                //odjęcie odpowiedniej ilości środków
                playersMoney -= cost;
                labelMoneyValue.Text = playersMoney.ToString();
                //dodanie nowej jednostki
                playerSoldiersOfFortune.Add(new SoldierOfFortune());
                int x = Int32.Parse(labelAmountOfSoldiersOfFortuneValue.Text);
                x++;
                labelAmountOfSoldiersOfFortuneValue.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiedniej ilości złota.", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za kupowanie jednostek - Medic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyMedic_Click(object sender, EventArgs e)
        {
            int cost = Int32.Parse(labelMedicCostValue.Text);
            if (playersMoney >= cost)
            {
                //odjęcie odpowiedniej ilości środków
                playersMoney -= cost;
                labelMoneyValue.Text = playersMoney.ToString();
                //dodanie nowej jednostki
                playerMedics.Add(new Medic());
                int x = Int32.Parse(labelAmountOfMedicsValue.Text);
                x++;
                labelAmountOfMedicsValue.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiedniej ilości złota.", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za kupowanie jednostek - Treasurer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyTreasurer_Click(object sender, EventArgs e)
        {
            int cost = Int32.Parse(labelTreasurerCostValue.Text);
            if(playersMoney >= cost)
            {
                //odjęcie odpowiedniej ilości środków
                playersMoney -= cost;
                labelMoneyValue.Text = playersMoney.ToString();
                //dodanie nowej jednostki
                playerTreasurers.Add(new Treasurer());
                int x = Int32.Parse(labelAmountOfTreasurersValue.Text);
                x++;
                labelAmountOfTreasurersValue.Text = x.ToString();
                numberOfIncomeMoney += 100;
                labelGoldIncomeValue.Text = numberOfIncomeMoney.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiedniej ilości złota.", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za kupowanie jednostek - Defence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyDefence_Click(object sender, EventArgs e)
        {
            int cost = Int32.Parse(labelDefenceCostValue.Text);
            if (playersMoney >= cost)
            {
                //odjęcie odpowiedniej ilości środków
                playersMoney -= cost;
                labelMoneyValue.Text = playersMoney.ToString();
                //dodanie nowje jednostki
                playerMedics.Add(new Medic());
                int x = Int32.Parse(labelAmountOfDefenceValue.Text);
                x++;
                labelAmountOfDefenceValue.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiedniej ilości złota.", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za atak gracza na jednostki komputera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            int playerDiceResult = 0;
            int computerDiceResult = 0;
            int playerAllAttack = 0;
            int playerAllDefence = 0;
            int computerAllAttack = 0;
            int computerAllDefence = 0;
            //wyznaczenie wartości wyrzuconych przez gracza i komputer
            using (FormAttackDice formAttackDice = new FormAttackDice())
            {
                if(formAttackDice.ShowDialog() != DialogResult.OK)
                {
                    if (formAttackDice.GetDiceResult())
                    {
                        //ustawnie wartości wyszuconych przez gracza i komputer
                        playerDiceResult = formAttackDice.GetPlayersResult();
                        computerDiceResult = formAttackDice.GetComputersResult();
                    }
                }
            }
            //obliczanie ogólnej siły ataku oraz siły obrony gracza
            if(playerFootWarriors.Count != 0)
            {
                playerAllAttack += playerFootWarriors.Count * playerFootWarriors[0].GetArrackPoints();
                playerAllDefence += playerFootWarriors.Count * playerFootWarriors[0].GetDefencePoints();
            }
            if(playerHorseWarriors.Count != 0)
            {
                playerAllAttack += playerHorseWarriors.Count * playerHorseWarriors[0].GetArrackPoints();
                playerAllDefence += playerHorseWarriors.Count * playerHorseWarriors[0].GetDefencePoints();
            }
            if(playerSoldiersOfFortune.Count != 0)
            {
                playerAllAttack += playerSoldiersOfFortune.Count * playerSoldiersOfFortune[0].GetArrackPoints();
                playerAllDefence += playerSoldiersOfFortune.Count * playerSoldiersOfFortune[0].GetDefencePoints();
            }
            if (playerDefences.Count != 0)
            {
                playerAllDefence += playerDefences.Count * playerDefences[0].GetDefencePoints();
            }
            //obliczanie ogólnej siły ataku oraz siły obrony komputera
            if (computerFootWarriors.Count != 0)
            {
                computerAllAttack += computerFootWarriors.Count * computerFootWarriors[0].GetArrackPoints();
                computerAllDefence += computerFootWarriors.Count * computerFootWarriors[0].GetDefencePoints();
            }
            if (computerHorseWarriors.Count != 0)
            {
                computerAllAttack += computerHorseWarriors.Count * computerHorseWarriors[0].GetArrackPoints();
                computerAllDefence += computerHorseWarriors.Count * computerHorseWarriors[0].GetDefencePoints();
            }
            if (computerSoldiersOfFortune.Count != 0)
            {
                computerAllAttack += computerSoldiersOfFortune.Count * computerSoldiersOfFortune[0].GetArrackPoints();
                computerAllDefence += computerSoldiersOfFortune.Count * computerSoldiersOfFortune[0].GetDefencePoints();
            }
            if (computerDefences.Count != 0)
            {
                computerAllDefence += computerDefences.Count * computerDefences[0].GetDefencePoints();
            }
            //dodanie skutków rzutów kostek
            playerAllAttack *= playerDiceResult;
            playerAllDefence *= playerDiceResult;
            computerAllAttack *= computerDiceResult;
            computerAllDefence *= computerDiceResult;
            //sprawdzanie kto wygrał potyczkę
            int result;
            //przypadek że gracz posiada więcej punktów ataku niż komputer punktów obrony
            if (playerAllAttack > computerAllDefence)
            {
                //zmienne przechowywujące ilość zabitych jednostek
                int killedFootWarriors = 0;
                int killedHorseWarriors = 0;
                int killedSoldiersOfFortune = 0;
                int killedMedics = 0;
                //zmienna przechowywująca ilość wszystkich zabitych jednostek
                int killedUnits = 0;
                //odjęcie punktów obrony komputera od ataku gracza
                playerAllAttack -= computerAllDefence;
                //usuwanie umocnień które niszczą się w trakcie walk
                if (computerDefences.Count != 0)
                {
                    int xx = computerDefences.Count;
                    for(int i=xx-1; i<computerDefences.Count; i--)
                    {
                        //usunięcie jednostki z listy
                        computerDefences.RemoveAt(i);
                    }
                }
                Random rnd = new Random();
                do
                {
                    int x = 0;
                    //wylosowanie, którą jednostkę należy zaatakować
                    result = rnd.Next(1, 5);
                    switch (result)
                    {
                        //atak na piechurów komputera
                        case 1:
                            x = computerFootWarriors.Count;
                            //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                            for (int i=x-1; i>=0; i--)
                            {
                                if(computerFootWarriors[i].GetHealthPoints() > 0 && playerAllAttack > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        playerAllAttack -= 50;
                                        computerFootWarriors[i].TakeAHit(50);
                                    } while (playerAllAttack > 0 && computerFootWarriors[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if(computerFootWarriors[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        computerFootWarriors.RemoveAt(i);
                                        killedUnits++;
                                        killedFootWarriors++;
                                    }
                                }
                            }
                        break;
                        //atak na jazdę konną komputera
                        case 2:
                            x = computerHorseWarriors.Count;
                            //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                            for (int i=x-1; i>=0; i--)
                            {
                                if (computerHorseWarriors[i].GetHealthPoints() > 0 && playerAllAttack > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        playerAllAttack -= 50;
                                        computerHorseWarriors[i].TakeAHit(50);
                                    } while (playerAllAttack > 0 && computerHorseWarriors[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (computerHorseWarriors[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        computerHorseWarriors.RemoveAt(i);
                                        killedUnits++;
                                        killedHorseWarriors++;
                                    }
                                }
                            }
                            break;
                        //atak na najemników komputera
                        case 3:
                            x = computerSoldiersOfFortune.Count;
                            //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                            for (int i=x-1; i>=0; i--)
                            {
                                if (computerSoldiersOfFortune[i].GetHealthPoints() > 0 && playerAllAttack > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        playerAllAttack -= 50;
                                        computerSoldiersOfFortune[i].TakeAHit(50);
                                    } while (playerAllAttack > 0 && computerSoldiersOfFortune[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (computerSoldiersOfFortune[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        computerSoldiersOfFortune.RemoveAt(i);
                                        killedUnits++;
                                        killedSoldiersOfFortune++;
                                    }
                                }
                            }
                            break;
                        //atak na medyków komputera
                        case 4:
                            x = computerMedics.Count;
                            //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                            for (int i=x-1; i>=0; i--)
                            {
                                if (computerMedics[i].GetHealthPoints() > 0 && playerAllAttack > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        playerAllAttack -= 50;
                                        computerMedics[i].TakeAHit(50);
                                    } while (playerAllAttack > 0 && computerMedics[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (computerMedics[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        computerMedics.RemoveAt(i);
                                        killedUnits++;
                                        killedMedics++;
                                    }
                                }
                            }
                            break;
                    }
                //Pętla wykonuje się dopudy dopóki gracz posiada punkty ataku oraz komputer posiada jednostki.
                } while (playerAllAttack > 0 && (computerFootWarriors.Count > 0 || computerHorseWarriors.Count > 0 || computerSoldiersOfFortune.Count > 0 || computerMedics.Count > 0));
                
                //leczenie (jeśli są medycy) oraz przywracanie punktów obrony (odpoczynek)
                if(computerMedics.Count != 0)
                {
                    for (int i = 0; i < computerMedics.Count; i++)
                    {
                        result = rnd.Next(1, 5);
                        switch (result)
                        {
                            //leczenie wylosowanej jednostki
                            case 1:
                                foreach (FootWarrior warior in computerFootWarriors) warior.Heal();
                                break;
                            case 2:
                                foreach (HorseWarrior warior in computerHorseWarriors) warior.Heal();
                                break;
                            case 3:
                                foreach (SoldierOfFortune warior in computerSoldiersOfFortune) warior.Heal();
                                break;
                            case 4:
                                foreach (Medic medic in computerMedics) medic.Heal();
                                break;
                        }
                    }
                }
                //reset wartości obrony jednostek - odpoczynek
                foreach(FootWarrior warior in computerFootWarriors) warior.Rest();
                foreach (HorseWarrior warior in computerHorseWarriors) warior.Rest();
                foreach (SoldierOfFortune warior in computerSoldiersOfFortune) warior.Rest();
                foreach (Medic medic in computerMedics) medic.Rest();
                //konstrukcja informacji wyświetlającej się w histori walki
                String answer = "";
                //jeśli gracz zniszczył jakieś jednostki konstrukcja jest następująca:
                if (killedUnits > 0)
                {
                    answer = " Gracz zniszczył:";
                    if (killedFootWarriors != 0) answer += (" " + killedFootWarriors + " piechurów");
                    if (killedHorseWarriors != 0) answer += (" " + killedHorseWarriors + " jednostek konnych");
                    if (killedSoldiersOfFortune != 0) answer += (" " + killedSoldiersOfFortune + " najemników");
                    if (killedMedics != 0) answer += (" " + killedMedics + " medyków");
                }
                //jeśli gracz nie zniszczył żadnej jednostki - ponieważ komputer nie posiadał takiej - konstrukcja jest taka:
                else
                {
                    answer = " Gracz nie zniszczył żadnych jednostek a posiada więcej punktów od komputera, zadaje więc 20 obrażeń";
                }
                //wpisanie informacji do histori walki
                richTextBoxHistoryOfBattle.AppendText("Gracz wyrzucił " + playerDiceResult + ", Komputer wyrzucił " + computerDiceResult + "." + answer + "." + "\r\n");
                //odejmowanie ogólnych punktów życi komputerowi w zależności od zabitych jednostek
                //jeśli komputer posiadal jakieś jednostki odejmuje ilość tych jednostek od ogólnego HP
                if (killedUnits > 0 && progressBarComputerHP.Value - killedUnits > 0)
                {
                    progressBarComputerHP.Value -= killedUnits;
                }
                //jeśli komputer nie posiadał żadnych jednostek odejmuje 20 od ogólnego HP
                else if(killedUnits == 0 && progressBarComputerHP.Value - 20 > 0)
                {
                    progressBarComputerHP.Value -= 20;
                }
                //jeśli komputer nie ma wystarczającej ilości HP na wykonanie jednej z wyżej wyszczególnionych operacji jego punkty HP zostają zzerowane
                else
                {
                    progressBarComputerHP.Value = 0;
                    using (FormEnd ending = new FormEnd("WYGRAŁEŚ!"))
                    {
                        if (ending.ShowDialog() != DialogResult.OK)
                        {
                            System.Windows.Forms.Application.Exit();
                        }
                    }
                }
            }
            //przypadek że gracz nie uzyskał potrzebnej ilości punktów ataku żeby zadać obrażenia komputerowi
            else if(playerAllAttack < computerAllDefence)
            {
                //zmienne przechowywujące ilość zabitych jednostek
                int killedFootWarriors = 0;
                int killedHorseWarriors = 0;
                int killedSoldiersOfFortune = 0;
                int killedMedics = 0;
                //zmienna przechowywująca ilość wszystkich zabitych jednostek
                int killedUnits = 0;
                //odjęcie punktów ataku gracza w celu ustanowienia z jaką siłą komputer kontratakuje
                computerAllDefence -= playerAllAttack;
                Random rnd = new Random();
                do
                {
                    int x = 0;
                    //wylosowanie, którą jednostkę atakuje komputer
                    result = rnd.Next(1, 5);
                    switch (result)
                    {
                        //kontratak na piechurów gracza
                        case 1:
                            x = playerFootWarriors.Count;
                            //pętla nie wykona się jeśli gracz nie posiada typu atakowanej jednostki.
                            for (int i = x - 1; i >= 0; i--)
                            {
                                if (playerFootWarriors[i].GetHealthPoints() > 0 && computerAllDefence > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty kontrataku zostaną wykorzystane
                                    do
                                    {
                                        computerAllDefence -= 50;
                                        playerFootWarriors[i].TakeAHit(50);
                                    } while (computerAllDefence > 0 && playerFootWarriors[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (playerFootWarriors[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        playerFootWarriors.RemoveAt(i);
                                        killedUnits++;
                                        killedFootWarriors++;
                                    }
                                }
                            }
                            break;
                        //kontratak na jazdę konną gracza
                        case 2:
                            x = playerHorseWarriors.Count;
                            //pętla nie wykona się jeśli gracz nie posiada typu atakowanej jednostki.
                            for (int i = x - 1; i >= 0; i--)
                            {
                                if (playerHorseWarriors[i].GetHealthPoints() > 0 && computerAllDefence > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        computerAllDefence -= 50;
                                        playerHorseWarriors[i].TakeAHit(50);
                                    } while (computerAllDefence > 0 && playerHorseWarriors[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (playerHorseWarriors[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        playerHorseWarriors.RemoveAt(i);
                                        killedUnits++;
                                        killedHorseWarriors++;
                                    }
                                }
                            }
                            break;
                        //atak na najemników gracza
                        case 3:
                            x = playerSoldiersOfFortune.Count;
                            //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                            for (int i = x - 1; i >= 0; i--)
                            {
                                if (playerSoldiersOfFortune[i].GetHealthPoints() > 0 && computerAllDefence > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        computerAllDefence -= 50;
                                        playerSoldiersOfFortune[i].TakeAHit(50);
                                    } while (computerAllDefence > 0 && playerSoldiersOfFortune[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (playerSoldiersOfFortune[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        playerSoldiersOfFortune.RemoveAt(i);
                                        killedUnits++;
                                        killedSoldiersOfFortune++;
                                    }
                                }
                            }
                            break;
                        //atak na medyków gracza
                        case 4:
                            x = playerMedics.Count;
                            //pętla nie wykona się jeśli gracz nie posiada typu atakowanej jednostki.
                            for (int i = x - 1; i >= 0; i--)
                            {
                                if (playerMedics[i].GetHealthPoints() > 0 && computerAllDefence > 0)
                                {
                                    //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                    do
                                    {
                                        computerAllDefence -= 50;
                                        playerMedics[i].TakeAHit(50);
                                    } while (computerAllDefence > 0 && playerMedics[i].GetHealthPoints() > 0);
                                    //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                    if (playerMedics[i].GetHealthPoints() == 0)
                                    {
                                        //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                        playerMedics.RemoveAt(i);
                                        killedUnits++;
                                        killedMedics++;
                                    }
                                }
                            }
                            break;
                    }
                    //Pętla wykonuje się dopudy dopóki gracz posiada punkty ataku oraz komputer posiada jednostki.
                } while (computerAllDefence > 0 && (playerFootWarriors.Count > 0 || playerHorseWarriors.Count > 0 || playerSoldiersOfFortune.Count > 0 || playerMedics.Count > 0));

                //leczenie (jeśli są medycy) oraz przywracanie punktów obrony (odpoczynek)
                if (playerMedics.Count != 0)
                {
                    result = rnd.Next(1, 5);
                    for (int i = 0; i < playerMedics.Count; i++)
                    {
                        result = rnd.Next(1, 5);
                        //leczenie wylosowanej jednostki
                        switch (result)
                        {
                            case 1:
                                foreach (FootWarrior warior in playerFootWarriors) warior.Heal();
                                break;
                            case 2:
                                foreach (HorseWarrior warior in playerHorseWarriors) warior.Heal();
                                break;
                            case 3:
                                foreach (SoldierOfFortune warior in playerSoldiersOfFortune) warior.Heal();
                                break;
                            case 4:
                                foreach (Medic medic in playerMedics) medic.Heal();
                                break;
                        }
                    }
                }
                //resetowanie wartości obrony jednostek - odpoczynek
                foreach (FootWarrior warior in playerFootWarriors) warior.Rest();
                foreach (HorseWarrior warior in playerHorseWarriors) warior.Rest();
                foreach (SoldierOfFortune warior in playerSoldiersOfFortune) warior.Rest();
                foreach (Medic medic in playerMedics) medic.Rest();

                //konstrukcja informacji wyświetlającej się w histori walki
                String answer = "";
                //jeśli kopmuter zniszczył jakieś jednostki gracza konstrukcja jest następująca:
                if (killedUnits > 0)
                {
                    answer = " Komputer zniszczył:";
                    if (killedFootWarriors != 0) answer += (" " + killedFootWarriors + " piechurów");
                    if (killedHorseWarriors != 0) answer += (" " + killedHorseWarriors + " jednostek konnych");
                    if (killedSoldiersOfFortune != 0) answer += (" " + killedSoldiersOfFortune + " najemników");
                    if (killedMedics != 0) answer += (" " + killedMedics + " medyków");
                }
                //jeśli komputer nie zniszczył żadnej jednostki - ponieważ gracz nie posiadał ich - konstrukcja jest taka:
                else
                {
                    answer = " Komputer nie zniszczył żadnych jednostek a posiada więcej punktów od gracza, zadaje więc 20 obrażeń";
                }
                //wpisanie informacji do histori walki
                richTextBoxHistoryOfBattle.AppendText("Gracz wyrzucił " + playerDiceResult + ", Komputer wyrzucił " + computerDiceResult + "." + answer + "." + "\r\n");
                //odejmowanie ogólnych punktów życia gracza w zależności od zabitych przed komputer jednostek
                //jeśli gracz posiadal jakieś jednostki odejmuje ilość tych jednostek od ogólnego HP gracza
                if (killedUnits > 0 && progressBarPlayerHP.Value - killedUnits > 0)
                {
                    progressBarPlayerHP.Value -= killedUnits;
                }
                //jeśli gracz nie posiadał żadnych jednostek odejmuje 20 od ogólnego HP
                else if (killedUnits == 0 && progressBarPlayerHP.Value - 20 > 0)
                {
                    progressBarPlayerHP.Value -= 20;
                }
                //jeśli gracz nie ma wystarczającej ilości HP na wykonanie jednej z wyżej wyszczególnionych operacji jego punkty HP zostają zzerowane
                else
                {
                    progressBarPlayerHP.Value = 0;
                    using (FormEnd ending = new FormEnd("PRZEGRAŁEŚ!"))
                    {
                        if (ending.ShowDialog() != DialogResult.OK)
                        {
                            System.Windows.Forms.Application.Exit();
                        }
                    }
                }
            }
            //przepadek że gracz oraz komputer mają tę samą liczbę punktów
            else if(playerAllAttack == computerAllDefence)
            {
                richTextBoxHistoryOfBattle.AppendText("Gracz wyrzucił " + playerDiceResult + ", Komputer wyrzucił " + computerDiceResult + " lecz ich punkty się równoważą. Nic się nie dzieje." + "\r\n");
            }            
        }

        /// <summary>
        /// Timer dzięki któremu wzrasta ilość pieniędzy posiadanych przez gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMoney_Tick(object sender, EventArgs e)
        {
            //inkrementacja zmiennej przechowywującej wartość pieniędzy posiadanych przez gracza.
            playersMoney += numberOfIncomeMoney;
            labelMoneyValue.Text = playersMoney.ToString();
        }

        /// <summary>
        /// Timer który jest odpowiedzialny za wizualizację czasu za jaki komputer zaatakuje gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerComputerAttack_Tick(object sender, EventArgs e)
        {
            //aktualizacja progressbaru odpowiedzialnego za wizualizację za jaki okres czasu komputer zaatakuje
            progressBarComputerAttacks.Value += 2;
            if(progressBarComputerAttacks.Value == 100)
            {
                progressBarComputerAttacks.Value = 0;
                ComputerIsAttacking();
            }
        }

        /// <summary>
        /// Timer odpowiedzialny za odświerzanie labeli, prograsbarów ect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            //aktualizacja wszystki labeli ect.
            labelAmountOfComputerFootWarriorsValue.Text = computerFootWarriors.Count.ToString();
            labelAmountOfComputerHorseSoldiersValue.Text = computerHorseWarriors.Count.ToString();
            labelAmountOfComputersMedicsValue.Text = computerMedics.Count.ToString();
            labelAmountOfComputersSoldiersOfFortuneValue.Text = computerSoldiersOfFortune.Count.ToString();
            labelAmountOfComputerTreasurerValue.Text = computerTreasurers.Count.ToString();
            labelAmountOfComputerDefenceValue.Text = computerDefences.Count.ToString();

            labelAmountOfFootWarriorsValue.Text = playerFootWarriors.Count.ToString();
            labelAmountOfHorseWarriorsValue.Text = playerHorseWarriors.Count.ToString();
            labelAmountOfMedicsValue.Text = playerMedics.Count.ToString();
            labelAmountOfSoldiersOfFortuneValue.Text = playerSoldiersOfFortune.Count.ToString();
            labelAmountOfTreasurersValue.Text = playerTreasurers.Count.ToString();
            labelAmountOfDefenceValue.Text = playerDefences.Count.ToString();

            labelMoneyValue.Text = playersMoney.ToString();
            
            
        }

        /// <summary>
        /// Funkcja odzwierciedlająca atak komputera na gracza
        /// </summary>
        private void ComputerIsAttacking()
        {
            //komputer zaatakuje tylko w sytuacji gdy posiada jakiekolwiek jednostki
            if(computerFootWarriors.Count != 0 || computerHorseWarriors.Count != 0 || computerSoldiersOfFortune.Count != 0)
            {
                timerComputerAttack.Stop();
                int playerDiceResult = 0;
                int computerDiceResult = 0;
                int playerAllAttack = 0;
                int playerAllDefence = 0;
                int computerAllAttack = 0;
                int computerAllDefence = 0;
                using (FormAttackDice formAttackDice = new FormAttackDice())
                {
                    if (formAttackDice.ShowDialog() != DialogResult.OK)
                    {
                        if (formAttackDice.GetDiceResult())
                        {
                            playerDiceResult = formAttackDice.GetPlayersResult();
                            computerDiceResult = formAttackDice.GetComputersResult();
                        }
                    }
                }
                //obliczanie ogólnej siły ataku oraz siły obrony gracza
                if (playerFootWarriors.Count != 0)
                {
                    playerAllAttack += playerFootWarriors.Count * playerFootWarriors[0].GetArrackPoints();
                    playerAllDefence += playerFootWarriors.Count * playerFootWarriors[0].GetDefencePoints();
                }
                if (playerHorseWarriors.Count != 0)
                {
                    playerAllAttack += playerHorseWarriors.Count * playerHorseWarriors[0].GetArrackPoints();
                    playerAllDefence += playerHorseWarriors.Count * playerHorseWarriors[0].GetDefencePoints();
                }
                if (playerSoldiersOfFortune.Count != 0)
                {
                    playerAllAttack += playerSoldiersOfFortune.Count * playerSoldiersOfFortune[0].GetArrackPoints();
                    playerAllDefence += playerSoldiersOfFortune.Count * playerSoldiersOfFortune[0].GetDefencePoints();
                }
                if (playerDefences.Count != 0)
                {
                    playerAllDefence += playerDefences.Count * playerDefences[0].GetDefencePoints();
                }
                //obliczanie ogólnej siły ataku oraz siły obrony komputera
                if (computerFootWarriors.Count != 0)
                {
                    computerAllAttack += computerFootWarriors.Count * computerFootWarriors[0].GetArrackPoints();
                    computerAllDefence += computerFootWarriors.Count * computerFootWarriors[0].GetDefencePoints();
                }
                if (computerHorseWarriors.Count != 0)
                {
                    computerAllAttack += computerHorseWarriors.Count * computerHorseWarriors[0].GetArrackPoints();
                    computerAllDefence += computerHorseWarriors.Count * computerHorseWarriors[0].GetDefencePoints();
                }
                if (computerSoldiersOfFortune.Count != 0)
                {
                    computerAllAttack += computerSoldiersOfFortune.Count * computerSoldiersOfFortune[0].GetArrackPoints();
                    computerAllDefence += computerSoldiersOfFortune.Count * computerSoldiersOfFortune[0].GetDefencePoints();
                }
                if (computerDefences.Count != 0)
                {
                    computerAllDefence += computerDefences.Count * computerDefences[0].GetDefencePoints();
                }
                //dodanie skutków rzutów kostek
                playerAllAttack *= playerDiceResult;
                playerAllDefence *= playerDiceResult;
                computerAllAttack *= computerDiceResult;
                computerAllDefence *= computerDiceResult;
                //sprawdzanie kto wygrał potyczkę
                int result;
                //przypadek że gracz posiada więcej punktów ataku niż komputer punktów obrony
                if (computerAllAttack > playerAllDefence)
                {
                    //zmienne przechowywujące ilość zabitych jednostek
                    int killedFootWarriors = 0;
                    int killedHorseWarriors = 0;
                    int killedSoldiersOfFortune = 0;
                    int killedMedics = 0;
                    //zmienna przechowywująca ilość wszystkich zabitych jednostek
                    int killedUnits = 0;
                    //odjęcie punktów obrony komputera od ataku gracza
                    //usuwanie umocnień które niszczą się w trakcie walk
                    if (playerDefences.Count != 0)
                    {
                        int xx = playerDefences.Count;
                        for (int i = xx - 1; i < playerDefences.Count; i--)
                        {
                            playerDefences.RemoveAt(i);
                        }
                    }
                    computerAllAttack -= playerAllDefence;
                    Random rnd = new Random();
                    do
                    {
                        int x = 0;
                        //wylosowanie, którą jednostkę należy zaatakować
                        result = rnd.Next(1, 5);
                        switch (result)
                        {
                            //atak na piechurów gracza
                            case 1:
                                x = playerFootWarriors.Count;
                                //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (playerFootWarriors[i].GetHealthPoints() > 0 && computerAllAttack > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            computerAllAttack -= 50;
                                            playerFootWarriors[i].TakeAHit(50);
                                        } while (computerAllAttack > 0 && playerFootWarriors[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (playerFootWarriors[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            playerFootWarriors.RemoveAt(i);
                                            killedUnits++;
                                            killedFootWarriors++;
                                        }
                                    }
                                }
                                break;
                            //atak na jazdę konną komputera
                            case 2:
                                x = playerHorseWarriors.Count;
                                //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (playerHorseWarriors[i].GetHealthPoints() > 0 && computerAllAttack > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            computerAllAttack -= 50;
                                            playerHorseWarriors[i].TakeAHit(50);
                                        } while (computerAllAttack > 0 && playerHorseWarriors[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (playerHorseWarriors[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            playerHorseWarriors.RemoveAt(i);
                                            killedUnits++;
                                            killedHorseWarriors++;
                                        }
                                    }
                                }
                                break;
                            //atak na najemników komputera
                            case 3:
                                x = playerSoldiersOfFortune.Count;
                                //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (playerSoldiersOfFortune[i].GetHealthPoints() > 0 && computerAllAttack > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            computerAllAttack -= 50;
                                            playerSoldiersOfFortune[i].TakeAHit(50);
                                        } while (computerAllAttack > 0 && playerSoldiersOfFortune[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (playerSoldiersOfFortune[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            playerSoldiersOfFortune.RemoveAt(i);
                                            killedUnits++;
                                            killedSoldiersOfFortune++;
                                        }
                                    }
                                }
                                break;
                            //atak na medyków komputera
                            case 4:
                                x = playerMedics.Count;
                                //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (playerMedics[i].GetHealthPoints() > 0 && computerAllAttack > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            computerAllAttack -= 50;
                                            playerMedics[i].TakeAHit(50);
                                        } while (computerAllAttack > 0 && playerMedics[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (playerMedics[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            playerMedics.RemoveAt(i);
                                            killedUnits++;
                                            killedMedics++;
                                        }
                                    }
                                }
                                break;
                        }
                        //Pętla wykonuje się dopudy dopóki gracz posiada punkty ataku oraz komputer posiada jednostki.
                    } while (computerAllAttack > 0 && (playerFootWarriors.Count > 0 || playerHorseWarriors.Count > 0 || playerSoldiersOfFortune.Count > 0 || playerMedics.Count > 0));

                    //leczenie (jeśli są medycy) oraz przywracanie punktów obrony (odpoczynek)
                    if (playerMedics.Count != 0)
                    {
                        result = rnd.Next(1, 5);
                        for (int i = 0; i < playerMedics.Count; i++)
                        {
                            result = rnd.Next(1, 5);
                            switch (result)
                            {
                                //leczenie wylosowanej jednostki
                                case 1:
                                    foreach (FootWarrior warior in playerFootWarriors) warior.Heal();
                                    break;
                                case 2:
                                    foreach (HorseWarrior warior in playerHorseWarriors) warior.Heal();
                                    break;
                                case 3:
                                    foreach (SoldierOfFortune warior in playerSoldiersOfFortune) warior.Heal();
                                    break;
                                case 4:
                                    foreach (Medic medic in playerMedics) medic.Heal();
                                    break;
                            }
                        }
                    }
                    //resetowanie wartości obrony jednostek - odpoczynek
                    foreach (FootWarrior warior in playerFootWarriors) warior.Rest();
                    foreach (HorseWarrior warior in playerHorseWarriors) warior.Rest();
                    foreach (SoldierOfFortune warior in playerSoldiersOfFortune) warior.Rest();
                    foreach (Medic medic in playerMedics) medic.Rest();

                    //konstrukcja informacji wyświetlającej się w histori walki
                    String answer = "";
                    //jeśli komputer zniszczył jakieś jednostki konstrukcja jest następująca:
                    if (killedUnits > 0)
                    {
                        answer = " Komputer zniszczył:";
                        if (killedFootWarriors != 0) answer += (" " + killedFootWarriors + " piechurów");
                        if (killedHorseWarriors != 0) answer += (" " + killedHorseWarriors + " jednostek konnych");
                        if (killedSoldiersOfFortune != 0) answer += (" " + killedSoldiersOfFortune + " najemników");
                        if (killedMedics != 0) answer += (" " + killedMedics + " medyków");
                    }
                    //jeśli koputer nie zniszczył żadnej jednostki - ponieważ gracz nie posiadał takiej - konstrukcja jest taka:
                    else
                    {
                        answer = " Kopmuter nie zniszczył żadnych jednostek a posiada więcej punktów od gracza, zadaje więc 20 obrażeń";
                    }
                    //wpisanie informacji do histori walki
                    richTextBoxHistoryOfBattle.AppendText("Gracz wyrzucił " + playerDiceResult + ", Komputer wyrzucił " + computerDiceResult + "." + answer + "." + "\r\n");
                    //odejmowanie ogólnych punktów życi komputerowi w zależności od zabitych jednostek
                    //jeśli gracz posiadal jakieś jednostki odejmuje ilość tych jednostek od ogólnego HP
                    if (killedUnits > 0 && progressBarPlayerHP.Value - killedUnits > 0)
                    {
                        progressBarPlayerHP.Value -= killedUnits;
                    }
                    //jeśli gracz nie posiadał żadnych jednostek odejmuje 20 od ogólnego HP
                    else if (killedUnits == 0 && progressBarPlayerHP.Value - 20 > 0)
                    {
                        progressBarPlayerHP.Value -= 20;
                    }
                    //jeśli gracz nie ma wystarczającej ilości HP na wykonanie jednej z wyżej wyszczególnionych operacji jego punkty HP zostają zzerowane
                    else
                    {
                        progressBarPlayerHP.Value = 0;
                        using (FormEnd ending = new FormEnd("PRZEGRAŁEŚ!"))
                        {
                            if (ending.ShowDialog() != DialogResult.OK)
                            {
                                System.Windows.Forms.Application.Exit();
                            }
                        }
                    }
                }
                //przypadek że komputer nie uzyskał potrzebnej ilości punktów ataku żeby zadać obrażenia graczu
                else if (computerAllAttack < playerAllDefence)
                {
                    //zmienne przechowywujące ilość zabitych jednostek
                    int killedFootWarriors = 0;
                    int killedHorseWarriors = 0;
                    int killedSoldiersOfFortune = 0;
                    int killedMedics = 0;
                    //zmienna przechowywująca ilość wszystkich zabitych jednostek
                    int killedUnits = 0;
                    //odjęcie punktów ataku kopmutera w celu ustanowienia z jaką siłą gracz kontratakuje
                    computerAllAttack -= playerAllDefence;
                    Random rnd = new Random();
                    do
                    {
                        int x = 0;
                        //wylosowanie, którą jednostkę atakuje komputer
                        result = rnd.Next(1, 5);
                        switch (result)
                        {
                            //kontratak na piechurów komputer
                            case 1:
                                x = computerFootWarriors.Count;
                                //pętla nie wykona się jeśli gracz nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (computerFootWarriors[i].GetHealthPoints() > 0 && playerAllDefence > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty kontrataku zostaną wykorzystane
                                        do
                                        {
                                            playerAllDefence -= 50;
                                            computerFootWarriors[i].TakeAHit(50);
                                        } while (playerAllDefence > 0 && computerFootWarriors[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (computerFootWarriors[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            computerFootWarriors.RemoveAt(i);
                                            killedUnits++;
                                            killedFootWarriors++;
                                        }
                                    }
                                }
                                break;
                            //kontratak na jazdę konną komputera
                            case 2:
                                x = computerHorseWarriors.Count;
                                //pętla nie wykona się jeśli gracz nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (computerHorseWarriors[i].GetHealthPoints() > 0 && playerAllDefence > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            playerAllDefence -= 50;
                                            computerHorseWarriors[i].TakeAHit(50);
                                        } while (playerAllDefence > 0 && computerHorseWarriors[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (computerHorseWarriors[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            computerHorseWarriors.RemoveAt(i);
                                            killedUnits++;
                                            killedHorseWarriors++;
                                        }
                                    }
                                }
                                break;
                            //atak na najemników kopmutera
                            case 3:
                                x = computerSoldiersOfFortune.Count;
                                //pętla nie wykona się jeśli komputer nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (computerSoldiersOfFortune[i].GetHealthPoints() > 0 && playerAllDefence > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            playerAllDefence -= 50;
                                            computerSoldiersOfFortune[i].TakeAHit(50);
                                        } while (playerAllDefence > 0 && computerSoldiersOfFortune[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (computerSoldiersOfFortune[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            computerSoldiersOfFortune.RemoveAt(i);
                                            killedUnits++;
                                            killedSoldiersOfFortune++;
                                        }
                                    }
                                }
                                break;
                            //atak na medyków kopmutera
                            case 4:
                                x = computerMedics.Count;
                                //pętla nie wykona się jeśli gracz nie posiada typu atakowanej jednostki.
                                for (int i = x - 1; i >= 0; i--)
                                {
                                    if (computerMedics[i].GetHealthPoints() > 0 && playerAllDefence > 0)
                                    {
                                        //atak następuje do chwili gdy dana jednostka nie ma już hp lub punkty ataku zostaną wykorzystane
                                        do
                                        {
                                            playerAllDefence -= 50;
                                            computerMedics[i].TakeAHit(50);
                                        } while (playerAllDefence > 0 && computerMedics[i].GetHealthPoints() > 0);
                                        //jeśli jednostka nie ma hp zostaje usunięta z listy. Konstrukcja pętli pozwala na usuwanie elementów listy dalej wykonując na niej operacje (na tej liście).
                                        if (computerMedics[i].GetHealthPoints() == 0)
                                        {
                                            //usunięcie jednostki z listy inkrementacja zmiennych informujących o zabitych jednostkach
                                            computerMedics.RemoveAt(i);
                                            killedUnits++;
                                            killedMedics++;
                                        }
                                    }
                                }
                                break;
                        }
                        //Pętla wykonuje się dopudy dopóki gracz posiada punkty ataku oraz komputer posiada jednostki.
                    } while (playerAllDefence > 0 && (computerFootWarriors.Count > 0 || computerHorseWarriors.Count > 0 || computerSoldiersOfFortune.Count > 0 || computerMedics.Count > 0));

                    //leczenie (jeśli są medycy) oraz przywracanie punktów obrony (odpoczynek)
                    if (computerMedics.Count != 0)
                    {
                        result = rnd.Next(1, 5);
                        for (int i=0; i<computerMedics.Count; i++)
                        {
                            result = rnd.Next(1, 5);
                            switch (result)
                            {
                                case 1:
                                    foreach (FootWarrior warior in computerFootWarriors) warior.Heal();
                                    break;
                                case 2:
                                    foreach (HorseWarrior warior in computerHorseWarriors) warior.Heal();
                                    break;
                                case 3:
                                    foreach (SoldierOfFortune warior in computerSoldiersOfFortune) warior.Heal();
                                    break;
                                case 4:
                                    foreach (Medic medic in computerMedics) medic.Heal();
                                    break;
                            }
                        }
                    }
                    foreach (FootWarrior warior in computerFootWarriors) warior.Rest();
                    foreach (HorseWarrior warior in computerHorseWarriors) warior.Rest();
                    foreach (SoldierOfFortune warior in computerSoldiersOfFortune) warior.Rest();
                    foreach (Medic medic in computerMedics) medic.Rest();

                    //konstrukcja informacji wyświetlającej się w histori walki
                    String answer = "";
                    //jeśli gracz zniszczył jakieś jednostki kopmutrea konstrukcja jest następująca:
                    if (killedUnits > 0)
                    {
                        answer = " Gracz zniszczył:";
                        if (killedFootWarriors != 0) answer += (" " + killedFootWarriors + " piechurów");
                        if (killedHorseWarriors != 0) answer += (" " + killedHorseWarriors + " jednostek konnych");
                        if (killedSoldiersOfFortune != 0) answer += (" " + killedSoldiersOfFortune + " najemników");
                        if (killedMedics != 0) answer += (" " + killedMedics + " medyków");
                    }
                    //jeśli gracz nie zniszczył żadnej jednostki - ponieważ kopmuter nie posiadał ich - konstrukcja jest taka:
                    else
                    {
                        answer = " Gracz nie zniszczył żadnych jednostek a posiada więcej punktów od kopmutera, zadaje więc 20 obrażeń";
                    }
                    //wpisanie informacji do histori walki
                    richTextBoxHistoryOfBattle.AppendText("Gracz wyrzucił " + playerDiceResult + ", Komputer wyrzucił " + computerDiceResult + "." + answer + "." + "\r\n");
                    //odejmowanie ogólnych punktów życia gracza w zależności od zabitych przed komputer jednostek
                    //jeśli kopmutea posiadal jakieś jednostki odejmuje ilość tych jednostek od ogólnego HP komputera
                    if (killedUnits > 0 && progressBarComputerHP.Value - killedUnits > 0)
                    {
                        progressBarComputerHP.Value -= killedUnits;
                    }
                    //jeśli kopmuter nie posiadał żadnych jednostek odejmuje 20 od ogólnego HP
                    else if (killedUnits == 0 && progressBarComputerHP.Value - 20 > 0)
                    {
                        progressBarComputerHP.Value -= 20;
                    }
                    //jeśli kopmutera nie ma wystarczającej ilości HP na wykonanie jednej z wyżej wyszczególnionych operacji jego punkty HP zostają zzerowane
                    else
                    {
                        progressBarComputerHP.Value = 0;
                        using (FormEnd ending = new FormEnd("WYGRAŁEŚ!"))
                        {
                            if (ending.ShowDialog() != DialogResult.OK)
                            {
                                System.Windows.Forms.Application.Exit();
                            }
                        }
                    }
                }
                //przepadek że gracz oraz komputer mają tę samą liczbę punktów
                else if (computerAllAttack == playerAllDefence)
                {
                    richTextBoxHistoryOfBattle.AppendText("Gracz wyrzucił " + playerDiceResult + ", Komputer wyrzucił " + computerDiceResult + " lecz ich punkty się równoważą. Nic się nie dzieje." + "\r\n");
                }
                timerComputerAttack.Start();
            }
        }

        /// <summary>
        /// Timer który dodaje złoto do zasobów komputera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerComputerMoney_Tick(object sender, EventArgs e)
        {
            computersMoney += numberOfIncomeMoneyComputer;
        }

        /// <summary>
        /// Timer który jest odpowiedzialny za kupowanie jednostek przez komputer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerComputerBuyingUnits_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            //losowanie jaką jednostkę ma kupic komputer
            int result = rnd.Next(1, 7);
            int howMany = 0;
            //zmienna pomocnicza
            int helper = 0;
            switch (result)
            {
                //kupienie przez komputer piechurów
                case 1:
                    helper = computersMoney % 500;
                    howMany = (computersMoney - helper)/500;
                    computersMoney -= howMany * 500;
                    for(int i=0; i<howMany; i++)
                    {
                        computerFootWarriors.Add(new FootWarrior());
                    }
                    break;
                //kupienie przez komputer jazdy konnej
                case 2:
                    helper = computersMoney % 1000;
                    howMany = (computersMoney - helper) / 1000;
                    computersMoney -= howMany * 1000;
                    for (int i = 0; i < howMany; i++)
                    {
                        computerHorseWarriors.Add(new HorseWarrior());
                    }
                    break;
                //kupienie przez komputer najemników
                case 3:
                    helper = computersMoney % 1500;
                    howMany = (computersMoney - helper) / 1500;
                    computersMoney -= howMany * 1500;
                    for (int i = 0; i < howMany; i++)
                    {
                        computerSoldiersOfFortune.Add(new SoldierOfFortune());
                    }
                    break;
                //kupienie przez komputer medyków
                case 4:
                    helper = computersMoney % 1000;
                    howMany = (computersMoney - helper) / 1000;
                    computersMoney -= howMany * 1000;
                    for (int i = 0; i < howMany; i++)
                    {
                        computerMedics.Add(new Medic());
                    }
                    break;
                //kupienie przez komputer skarbników
                case 5:
                    helper = computersMoney % 2000;
                    howMany = (computersMoney - helper) / 2000;
                    computersMoney -= howMany * 2000;
                    for (int i = 0; i < howMany; i++)
                    {
                        computerTreasurers.Add(new Treasurer());
                        //zwiększenie przychodu komputera
                        numberOfIncomeMoneyComputer += 100;
                    }
                    break;
                //kupienie przez komputer barykad
                case 6:
                    helper = computersMoney % 750;
                    howMany = (computersMoney - helper) / 750;
                    computersMoney -= howMany * 750;
                    for (int i = 0; i < howMany; i++)
                    {
                        computerDefences.Add(new Defence());
                    }
                    break;
            }
        } 
    }
}
