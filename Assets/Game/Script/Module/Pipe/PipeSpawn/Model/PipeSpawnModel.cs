using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeSpawnModel : GameBaseModel, IPipeSpawnModel
    {
        public bool IsPlaying { get; private set; } = false;
        public Vector3 SpawnPoint { get; private set; } = new Vector3();
        public float SpawnRate { get; private set; } = 3f;
        public float SpawnGap { get; private set; } = 4f;
        public float MinYSpawnPoint { get; private set; } = 3.2f;
        public float MaxYSpawnPoint { get; private set; } = -0.7f;

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }

        public void MoveSpawnPoint()
        {
            SpawnPoint += Vector3.right * SpawnGap;
            SetDataAsDirty();
        }
    }
}
