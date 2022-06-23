using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdMovementModel : GameBaseModel, IBirdMovementModel
    {
        public float Force { get; private set; } = 10000f;
    }
}
