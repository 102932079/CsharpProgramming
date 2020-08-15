using System;
using System.Collections.Generic;


namespace BingoCard
{
    public class Player
    {
        //create this player class for able to hold list of card
        public string PlayerName;
        public Card card;
        public Player ()
        {
           
        }

        public Player(string playerName, Card card)
        {
            PlayerName = playerName;
            this.card = card;
        }

        public void AddCard(int boardSize, int mintRange, int maxRange)
        {
            card = new Card(boardSize, mintRange, maxRange)
        }
    }
}