using System.Collections;

namespace app 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("michael jordan", 4, 2);
            Player player2 = new Player(player1);
            // player2.print(); //michael jordan 4 3
            Player player3 = player2 + 1;
            player3.X = -1; // sets x coordinate to -1
            // player3.print();  //michael jordan -1 4
            player1++; //exception
            // player2.print(); // michael jordan 4 2
            BBPlayer player4 = new BBPlayer("kobe", 1, "shooting guard");
            // player4.print(); //kobe 0 1 forward
            BBPlayer player5 = new BBPlayer("kawhi", 1, 2, "small forward");
            // player5.print();
            Console.WriteLine(Player.PlayerCount);
            foreach(Player p in Player.playerList){
                p.print();
            }
        }
    }
    public interface IPlayer{
        void print();
    }

    public class Player:IPlayer{

        public static List<Player> playerList = new List<Player>();

        private static int playerCount = 0;
        protected string mName;
        protected int x;
        protected int y;
        public Player(): this("", 0, 0){}
        public Player(string name, int x=0, int y=0){
            mName = name;
            X = x;
            this.y = y;
            ++Player.playerCount;
            playerList.Add(this);
        }
        public Player(Player other){
            this.mName = other.mName;
            X = other.x;
            this.y = other.y;
            ++Player.playerCount;
            playerList.Add(this);
        }
        public int X{
            get{
                return this.x;
            }
            set{
                this.x = value;
            }
        }
        public int Y{
            get{
                return this.y;
            }
        }
        public static int PlayerCount{
            get{
                return Player.playerCount;
            }
        }
        public virtual void print(){
            Console.WriteLine($"{this.mName} {this.x} {this.y}");
        }
        public static Player operator ++(Player p){
            try {
                if(p.x >= 4 || p.y >= 4){
                    throw new CustomException("coordinates cannot exceed four");
                }
                p.x++;
                p.y++;
            }
            catch(CustomException ce){
                Console.WriteLine(ce.Message);
            }
            return p;
        }
        public static Player operator +(Player p, int v){
            Player other = new Player(p.mName, p.x+v, p.y+v);
            return other;
        }
    }
}