namespace Topic_7_Structs_UnitTests
{
    public struct Voter
    {
        public int id;
        public bool hasVoted;

        public Voter(int id, bool hasVoted)
        {
            this.id = id;
            this.hasVoted = hasVoted;
        }
    }
}
