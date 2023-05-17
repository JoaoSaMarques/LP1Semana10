namespace PlayerManager3
{
    public class Player : IComparable<Player>
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public int CompareTo(Player other)
        {
            //Compare players based on their scores
            //Sorting will be in descending order (from highest to lowest)
            return other.Score.CompareTo(Score);
        }
    }
}
