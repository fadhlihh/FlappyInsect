using UnityEngine;
namespace FlappyInsect.Message
{
    public class AddCoinMessage
    {
        public GameObject Coin { get; private set; }
        public AddCoinMessage(GameObject coin)
        {
            Coin = coin;
        }
    }
}
