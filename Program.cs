using System.Collections;

namespace app 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player{
                mName = "michael jordan",
                x = 4,
                y =  2
            };
            Player player2 = new Player(player1);
            Player player3 = player2 + 1;
            player3.X = -1; 
            player1++; //exception
            BBPlayer player4 = new BBPlayer("kobe", 1, "shooting guard");
            BBPlayer player5 = new BBPlayer("kawhi", 1, 2, "small forward");
            Console.WriteLine(Player.PlayerCount);
            foreach(Player p in Player.playerList){
                p.print();
            }
        }
    }
}