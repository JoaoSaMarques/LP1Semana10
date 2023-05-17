namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }

        public int Compare(Player x, Player y)
        {
            //Compare players based on their names
            int result = string.Compare(x.Name, y.Name);

            //Reverse the result if the sorting order is descending
            if (!ascending)
                result *= -1;

            return result;
        }
    }
}