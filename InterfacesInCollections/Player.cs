using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesInCollections
{
    public class Player
    {
        private int runs;
        private string names;


        public Player(int runs, string names)
        {
            this.runs = runs;
            this.names = names;
        }

        public override string ToString()
        {
            return $"{runs}-----------{names}";
        }
    }



    public class Team : IEnumerable//When we have collections we need to call IEnumerable
    {

        Player[] players;   //Class array
        public Team()
        {
            players = new Player[3];
            players[0] = new Player(1, "Virat");
            players[1] = new Player(2, "Sachin");
            players[2] = new Player(3, "Dhoni");
        }
        public IEnumerator GetEnumerator()
        {
           return players.GetEnumerator();
        }
    }
}
