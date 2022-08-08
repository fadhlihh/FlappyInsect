namespace FlappyInsect.Message
{
    public struct UpdateCoinMessage
    {
        public int Coin { get; }
        public UpdateCoinMessage(int coin)
        {
            Coin = coin;
        }
    }
}
