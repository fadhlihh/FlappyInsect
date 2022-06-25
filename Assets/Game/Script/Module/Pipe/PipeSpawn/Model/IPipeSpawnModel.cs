using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public interface IPipeSpawnModel : IGameBaseModel
    {
        public bool IsPlaying { get; }
        public Vector3 SpawnPoint { get; }
        public float SpawnRate { get; }
        public float SpawnGap { get; }
        public float MinYSpawnPoint { get; }
        public float MaxYSpawnPoint { get; }
    }
}
