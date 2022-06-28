namespace Game.Module.Bird
{
    public class BirdDeathMessage
    {
        public int Score { get; }
        public int HighScore { get; }
        public BirdDeathMessage(int score, int highScore)
        {
            Score = score;
            HighScore = highScore;
        }
    }
}
