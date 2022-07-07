using UnityEngine;
using Game.Base.MVC;

namespace Game.Module.PipeContainer
{
    public interface IPipeContainerModel : IGameBaseModel
    {
        public bool IsPlaying { get; }
        public Vector3 SpawnPoint { get; }
        public Vector3 Position { get; }
        public Vector3 DespawnPosition { get; }
        public float SpawnRate { get; }
        public float SpawnGap { get; }
        public float MinYSpawnPoint { get; }
        public float MaxYSpawnPoint { get; }
        public float ScrollSpeed { get; }

    }
}
