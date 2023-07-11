using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesInCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            foreach (Player p in team)
            {
                Console.WriteLine(p);
            }
        }
    }
}
