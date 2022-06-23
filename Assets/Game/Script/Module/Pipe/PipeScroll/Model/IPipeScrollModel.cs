using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public interface IPipeScrollModel : IGameBaseModel
    {
        public float ScrollSpeed { get; }
    }
}
