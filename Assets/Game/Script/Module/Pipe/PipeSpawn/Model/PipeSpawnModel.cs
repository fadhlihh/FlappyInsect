using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeSpawnModel : GameBaseModel
    {
        public bool IsPlaying { get; private set; } = false;
        public Vector3 SpawnPoint { get; private set; } = new Vector3();
        public int SpawnDelay { get; private set; } = 2500;
        public float SpawnGap { get; private set; } = 4f;
        public float MinYSpawnPoint { get; private set; } = 3.2f;
        public float MaxYSpawnPoint { get; private set; } = -0.7f;

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
        }

        public void MoveSpawnPoint()
        {
            SpawnPoint += Vector3.right * SpawnGap;
        }
    }
}
