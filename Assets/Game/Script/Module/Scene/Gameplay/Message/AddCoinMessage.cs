using UnityEngine;
namespace FlappyInsect.Message
{
    public struct AddCoinMessage
    {
        public GameObject Coin { get; private set; }
        public AddCoinMessage(GameObject coin)
        {
            Coin = coin;
        }
    }
}
