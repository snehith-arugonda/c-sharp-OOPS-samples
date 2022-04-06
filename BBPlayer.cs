namespace app
{
    public class BBPlayer : Player
    {
        private string position;
        public BBPlayer(string name, int y, string position) : base(name, 0, y)
        {
            this.position = position;
        }
        public BBPlayer(string name, int x, int y, string position) : base(name, x, y)
        {
            this.position = position;
        }
        public override void print()
        {
            Console.WriteLine($"{this.mName} {this.x} {this.y} {this.position}");
        }
    }
}