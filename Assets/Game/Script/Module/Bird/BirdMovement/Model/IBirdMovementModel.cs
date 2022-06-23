using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public interface IBirdMovementModel : IGameBaseModel
    {
        public float Force { get; }
    }
}
