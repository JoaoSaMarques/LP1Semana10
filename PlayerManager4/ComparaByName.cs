namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool ascending;

        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }
    }
}