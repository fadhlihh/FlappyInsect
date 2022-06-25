using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public interface IPipeScrollModel : IGameBaseModel
    {
        public Vector3 Position { get; }
        public bool IsPlaying { get; }
        public float ScrollSpeed { get; }
    }
}
