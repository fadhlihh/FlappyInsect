namespace FlappyInsect.Message
{
    public struct UpdateScoreMessage
    {
        public int Score { get; private set; }
        public UpdateScoreMessage(int score)
        {
            Score = score;
        }
    }
}
