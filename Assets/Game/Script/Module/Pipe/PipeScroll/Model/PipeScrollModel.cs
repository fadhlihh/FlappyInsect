using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeScrollModel : GameBaseModel, IPipeScrollModel
    {
        public bool IsPlaying { get; private set; } = false;
        public float ScrollSpeed { get; private set; } = 1f;

        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }
    }
}
