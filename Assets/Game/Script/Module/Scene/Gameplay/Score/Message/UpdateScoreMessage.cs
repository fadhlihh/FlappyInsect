namespace FlappyBird.Module.Score
{
    public class ShowCalcScoreMessage
    {
        public int Score { get; private set; }
        public int HighScore { get; private set; }
        public ShowCalcScoreMessage(int score, int highScore)
        {
            Score = score;
            HighScore = highScore;
        }
    }
}
