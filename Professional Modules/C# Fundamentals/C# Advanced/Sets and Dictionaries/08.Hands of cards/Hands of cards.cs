using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HandsOfCards
{
    public static void Main()
    {
        Dictionary<string, int> cards = new Dictionary<string, int>();
        Dictionary<string, int> typeCards = new Dictionary<string, int>();
        Dictionary<string, HashSet<string>> nameOfPlayers = new Dictionary<string, HashSet<string>>();

        for (int i = 2; i < 15; i++)
        {
            string[] card = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            cards.Add(card[i - 2], i);
        }
        for (int i = 1; i < 5; i++)
        {
            string[] typeCard = { "C", "D", "H", "S" };
            typeCards.Add(typeCard[i - 1], i);
        }

        int sum = 0;
        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string namePlayer = input[0];
        while (!namePlayer.Equals("JOKER"))
        {
            HashSet<string> handsCardsHashSet = new HashSet<string>();
            for (int i = 1; i < input.Length; i++)
            {

                handsCardsHashSet.Add(input[i]);
            }
            if (!nameOfPlayers.ContainsKey(input[0]))
            {
                nameOfPlayers.Add(namePlayer, new HashSet<string>(handsCardsHashSet));
            }
            else
            {
                foreach (var item in handsCardsHashSet)
                {
                    nameOfPlayers[namePlayer].Add(item);
                }
                
            }
            input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            namePlayer = input[0];
        }
        foreach (var item in nameOfPlayers)
        {
            HashSet<string> handsCards = item.Value;
            foreach (var it in handsCards)
            {
                string split = it;
                string ch;
                string ch1; ;
                if (split.Length > 2)
                {
                    ch = it.Substring(0, 2);
                    ch1 = it.Substring(2);
                }
                else
                {
                    ch = it.Substring(0, 1);
                    ch1 = it.Substring(1, 1);
                }


                int sum1 = cards[ch];
                int sum2 = typeCards[ch1];
                sum += sum1 * sum2;
            }

            Console.WriteLine($"{item.Key} {sum}");
            sum = 0;
        }

    }
    
}
