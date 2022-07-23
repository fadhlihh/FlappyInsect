namespace FlappyInsect.Message
{
    public class UpdateCoinMessage
    {
        public int Coin { get; }
        public UpdateCoinMessage(int coin)
        {
            Coin = coin;
        }
    }
}
