namespace Game.Module.Score
{
    public class UpdateScoreMessage
    {
        public int Score { get; private set; }
        public UpdateScoreMessage(int score)
        {
            Score = score;
        }
    }
}
