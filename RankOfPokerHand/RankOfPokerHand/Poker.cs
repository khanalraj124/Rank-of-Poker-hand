using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankOfPokerHand
{
    public class Poker
    {
        public static int GetRank(string c1, string c2, string c3, string c4, string c5)
        {
            Dictionary<char, int> rankMap = new Dictionary<char, int>
            {
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9},
                {'T', 10},
                {'J', 11},
                {'Q', 12},
                {'K', 13},
                {'A', 14}
            };
            string[] cards = { c1, c2, c3, c4, c5 };
            Array.Sort(cards, (a, b) => rankMap[a[0]].CompareTo(rankMap[b[0]]));

            if (IsStraightFlush(cards))
            {
                return 9; // Straight Flush
            }
            else if (IsFourOfAKind(cards))
            {
                return 8; // Four of a Kind
            }
            else if (IsFullHouse(cards))
            {
                return 7; // Full House
            }
            else if (IsFlush(cards))
            {
                return 6; // Flush
            }
            else if (IsStraight(cards))
            {
                return 5; // Straight
            }
            else if (IsThreeOfAKind(cards))
            {
                return 4; // Three of a Kind
            }
            else if (IsTwoPair(cards))
            {
                return 3; // Two Pair
            }
            else if (IsPair(cards))
            {
                return 2; // Pair
            }
            else
            {
                return 1; // High Card
            }
        }

        private static bool IsStraightFlush(string[] cards)
        {
            return IsStraight(cards) && IsFlush(cards);
        }

        private static bool IsFourOfAKind(string[] cards)
        {
            return cards[0][0] == cards[3][0] || cards[1][0] == cards[4][0];
        }

        private static bool IsFullHouse(string[] cards)
        {
            return (cards[0][0] == cards[1][0] && cards[2][0] == cards[4][0])
                   || (cards[0][0] == cards[2][0] && cards[3][0] == cards[4][0]);
        }

        private static bool IsFlush(string[] cards)
        {
            return cards[0][1] == cards[1][1] && cards[1][1] == cards[2][1]
                   && cards[2][1] == cards[3][1] && cards[3][1] == cards[4][1];
        }

        private static bool IsStraight(string[] cards)
        {
            int[] ranks = cards.Select(card => RankToInt(card[0])).ToArray();

            return ranks[0] == ranks[1] - 1
                   && ranks[1] == ranks[2] - 1
                   && ranks[2] == ranks[3] - 1
                   && ranks[3] == ranks[4] - 1;
        }

        private static bool IsThreeOfAKind(string[] cards)
        {
            return cards[0][0] == cards[2][0] || cards[1][0] == cards[3][0] || cards[2][0] == cards[4][0];
        }

        private static bool IsTwoPair(string[] cards)
        {
            return (cards[0][0] == cards[1][0] && cards[2][0] == cards[3][0])
                   || (cards[0][0] == cards[1][0] && cards[3][0] == cards[4][0])
                   || (cards[1][0] == cards[2][0] && cards[3][0] == cards[4][0]);
        }

        private static bool IsPair(string[] cards)
        {
            return cards[0][0] == cards[1][0] || cards[1][0] == cards[2][0] || cards[2][0] == cards[3][0] || cards[3][0] == cards[4][0];
        }

        private static int RankToInt(char rank)
        {
            Dictionary<char, int> rankMap = new Dictionary<char, int>
        {
            {'2', 2},
            {'3', 3},
            {'4', 4},
            {'5', 5},
            {'6', 6},
            {'7', 7},
            {'8', 8},
            {'9', 9},
            {'T', 10},
            {'J', 11},
            {'Q', 12},
            {'K', 13},
            {'A', 14}
        };

            return rankMap[rank];
        }

        public static void Main()
        {
            Console.WriteLine(GetRank("2D", "3D", "4D", "5D", "2C")); // Output: 2 (Pair)
            Console.WriteLine(GetRank("TD", "3D", "TC", "3S", "3C")); // Output: 7 (Full house)
            Console.WriteLine(GetRank("2H", "4H", "6H", "5H", "3H")); // Output: 9 (Straight flush)
        }
    }
}
