using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace FlappyInsect.Module.CoinPool
{
    public class CoinPoolView : ObjectView<ICoinPoolModel>
    {
        private UnityAction _onMovePosition;
        private UnityAction _onDespawnCoin;

        public void SetCallbacks(UnityAction onMovePosition, UnityAction onDespawnCoin)
        {
            _onMovePosition = onMovePosition;
            _onDespawnCoin = onDespawnCoin;
        }

        public GameObject CreateCoinObject()
        {
            GameObject coinPrefab = Resources.Load<GameObject>(@"Prefabs/Coin/Coin");
            GameObject coin = Object.Instantiate(coinPrefab, transform);
            return coin;
        }

        protected override void InitRenderModel(ICoinPoolModel model)
        {
            transform.position = model.Position;
        }

        protected override void UpdateRenderModel(ICoinPoolModel model)
        {
            transform.position = model.Position;
        }

        private void Update()
        {
            _onMovePosition?.Invoke();
            _onDespawnCoin?.Invoke();
        }
    }
}
