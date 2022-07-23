using UnityEngine;
using Agate.MVC.Base;

namespace FlappyInsect.Module.ObstaclePool
{
    public interface IObstaclePoolModel : IBaseModel
    {
        public bool IsPlaying { get; }
        public Vector3 SpawnPoint { get; }
        public Vector3 Position { get; }
        public Vector3 DespawnPosition { get; }
    }
}
