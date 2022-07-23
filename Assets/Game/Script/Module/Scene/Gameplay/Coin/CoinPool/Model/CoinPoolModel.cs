using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace FlappyInsect.Module.CoinPool
{
    public class CoinPoolModel : BaseModel, ICoinPoolModel
    {
        public bool IsPlaying { get; private set; } = false;
        public int PoolSize { get; private set; } = 5;
        public Vector3 Position { get; private set; } = new Vector3(1.85f, 0.5f, 10f);
        public float ScrollSpeed { get; private set; } = 1f;
        public Vector3 SpawnPoint { get; private set; } = new Vector3();
        public float SpawnGap { get; private set; } = 4f;
        public float MinYSpawnPoint { get; private set; } = 3.2f;
        public float MaxYSpawnPoint { get; private set; } = -0.7f;
        public Vector3 DespawnPosition { get; private set; } = new Vector3(-.2f, 0.5f, 10f);

        private List<GameObject> _coinPool = new List<GameObject>();

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }

        public void SetPosition(Vector3 position)
        {
            Position = position;
            SetDataAsDirty();
        }

        public void SetDespawnPosition(Vector3 despawnPosition)
        {
            DespawnPosition = despawnPosition;
            SetDataAsDirty();
        }

        public void MoveSpawnPoint()
        {
            SpawnPoint += Vector3.right * SpawnGap;
            SetDataAsDirty();
        }

        public void AddCoin(GameObject coin)
        {
            _coinPool.Add(coin);
            SetDataAsDirty();
        }

        public void RemoveCoin(GameObject coin)
        {
            _coinPool.Remove(coin);
            SetDataAsDirty();
        }

        public GameObject GetCoinInFront()
        {
            return _coinPool[0];
        }
    }
}
