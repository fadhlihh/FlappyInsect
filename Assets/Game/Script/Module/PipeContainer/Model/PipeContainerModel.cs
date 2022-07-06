using System.Collections.Generic;
using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.PipeContainer
{
    public class PipeContainerModel : GameBaseModel, IPipeContainerModel
    {
        public bool IsPlaying { get; private set; } = false;
        public Queue<GameObject> Pipes { get; private set; } = new Queue<GameObject>();
        public Vector3 Position { get; private set; } = new Vector3(1.5f, 0.5f, 10f);
        public Vector3 SpawnPoint { get; private set; } = new Vector3();
        public float SpawnRate { get; private set; } = 3f;
        public float SpawnGap { get; private set; } = 4f;
        public float MinYSpawnPoint { get; private set; } = 3.2f;
        public float MaxYSpawnPoint { get; private set; } = -0.7f;
        public float ScrollSpeed { get; private set; } = 1f;
        public Vector3 DespawnPosition { get; private set; } = new Vector3(-.2f, 0.5f, 10f);

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }

        public void SetPosition(Vector3 position)
        {
            Position = position;
        }

        public void SetDespawnPosition(Vector3 despawnPosition)
        {
            DespawnPosition = despawnPosition;
        }

        public void MoveSpawnPoint()
        {
            SpawnPoint += Vector3.right * SpawnGap;
            SetDataAsDirty();
        }

        public void AddPipe(GameObject pipe)
        {
            Pipes.Enqueue(pipe);
        }

        public GameObject GetPipe()
        {
            return Pipes.Dequeue();
        }
    }
}
