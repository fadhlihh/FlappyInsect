using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;
using System.Collections;

namespace FlappyInsect.Module.CoinPool
{
    public class CoinPoolController : ObjectController<CoinPoolController, CoinPoolModel, ICoinPoolModel, CoinPoolView>
    {
        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            SetInitPosition();
        }

        public override void SetView(CoinPoolView view)
        {
            base.SetView(view);
            InitPoolObject();
        }

        public void OnStartPlay(StartPlayMessage message)
        {
            _model.SetIsPlaying(true);
            _view.SetCallbacks(OnMovePosition, OnDespawnCoin);
        }

        public void OnAddCoin(AddCoinMessage message)
        {
            DespawnCoin(message.Coin);
        }

        public void OnGameOver(GameOverMessage message)
        {
            _model.SetIsPlaying(false);
        }

        private void SetInitPosition()
        {
            Vector3 worldPointPosition = Camera.main.ViewportToWorldPoint(_model.Position);
            _model.SetPosition(worldPointPosition);
            Vector3 worldPointDespawnPosition = Camera.main.ViewportToWorldPoint(_model.DespawnPosition);
            _model.SetDespawnPosition(worldPointDespawnPosition);
        }

        private void InitPoolObject()
        {
            for (int i = 0; i < _model.PoolSize; i++)
            {
                GameObject coin = _view.CreateCoinObject();
                SpawnCoin(coin);
            }
        }

        private void SpawnCoin(GameObject coin)
        {
            Vector3 coinYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);
            coin.transform.localPosition = _model.SpawnPoint + coinYPosition;
            _model.AddCoin(coin);
            coin.SetActive(true);
            _model.MoveSpawnPoint();
        }

        private void OnMovePosition()
        {
            if (_model.IsPlaying)
            {
                Vector3 position = _model.Position + (Vector3.left * _model.ScrollSpeed * Time.deltaTime);
                _model.SetPosition(position);
            }
        }

        private void OnDespawnCoin()
        {
            GameObject coin = _model.GetCoinInFront();
            float coinPosition = coin.transform.position.x;
            float despawnPosition = _model.DespawnPosition.x;
            if (coinPosition <= despawnPosition)
            {
                DespawnCoin(coin);
            }
        }

        private void DespawnCoin(GameObject coin)
        {
            _model.RemoveCoin(coin);
            coin.SetActive(false);
            SpawnCoin(coin);
        }
    }
}
