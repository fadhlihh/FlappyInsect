namespace FlappyInsect.Message
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
