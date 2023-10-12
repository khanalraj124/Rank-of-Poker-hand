# Rank-of-Poker-hand
This is a C# console application to find the rank of the Poker 

Given five cards from a deck of poker cards, return the rank of the hand as an integer:
9 - Straight Flush (All same suit, consecutive rank)
8 - Four of a kind (Four cards with same rank)
7 - Full house (3 of a kind + 2 of a kind)
6 - Flush (All same suit)
5 - Straight (5 cards with consecutive rank)
4 - Three of a kind (Three cards with same rank)
3 - Two pair (Two pairs of differing rank)
2 - Pair (Two cards with same rank)
1 - High card
Input values are two-character strings consisting of the Rank followed by the Suit as follows:
Rank: 2 3 4 5 6 7 8 9 10 Jack Queen King Ace
Character: 2 3 4 5 6 7 8 9 T J Q K A
Suit: Spades Hearts Clubs Diamonds
Character: S H C D
The Ace of Spades would be represented as "AS" and the Seven of Diamonds would be represented as "7D" .
Problem Statement

Implement a function named getRank() that takes five strings as parameters and returns the poker rank of the hand.
public class Poker {
public static int getRank(String c1, String c2, String c3, String c4, String c5) { return 1; }



Sample hands
getRank("2D", "3D", "4D", "5D", "2C") -> 2 (Pair)
getRank("TD", "3D", "TC", "3S", "3C") -> 7 (Full house)
getRank("2H", "4H", "6H", "5H", "3H") -> 9 (Straight flush)
For this question, Aces are only high.
