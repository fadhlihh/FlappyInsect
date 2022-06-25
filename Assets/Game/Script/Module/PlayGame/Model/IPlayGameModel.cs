using UnityEngine;

using Game.Base.MVC;

namespace Game.Base.MVC
{
    public interface IPlayGameModel : IGameBaseModel
    {
        public bool IsPlaying { get; }
    }
}
