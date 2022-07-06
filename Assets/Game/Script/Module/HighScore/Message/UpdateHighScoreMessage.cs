namespace Game.Module.HighScore
{
    public class UpdateHighScoreMessage
    {
        public int HighScore { get; private set; }

        public UpdateHighScoreMessage(int highScore)
        {
            HighScore = highScore;
        }
    }
}
