using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeScrollModel : GameBaseModel, IPipeScrollModel
    {
        public Vector3 Position { get; private set; } = new Vector3(7.08f, 0f, 0f);
        public bool IsPlaying { get; private set; } = false;
        public float ScrollSpeed { get; private set; } = 1f;

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
    }
}
