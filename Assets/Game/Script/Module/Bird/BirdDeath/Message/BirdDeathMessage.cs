namespace Game.Module.Bird
{
    public class BirdDeathMessage
    {
        public int Score { get; }
        public BirdDeathMessage(int score)
        {
            Score = score;
        }
    }
}
