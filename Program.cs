namespace app 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player2 = new Player("michael jordan", 4, 2);
            Player player3 = new Player(player2);
            player3.print(); //michael jordan 4 3
            Player player4 = player2 + 1;
            player4.print();  //michael jordan 5 4
            player2++; //exception
            player2.print(); // michael jordan 4 2
            BBPlayer player1 = new BBPlayer("kobe", 1, "shooting guard");
            player1.print(); //kobe 0 1 forwrad
        }
    }
    public interface IPlayer{
        void print();
    }

    public class Player:IPlayer{

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
        }
        public Player(Player other){
            this.mName = other.mName;
            X = other.x;
            this.y = other.y;
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
        public int PlayerCount{
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