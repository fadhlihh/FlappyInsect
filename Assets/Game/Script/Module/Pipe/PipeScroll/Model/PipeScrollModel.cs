using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeScrollModel : GameBaseModel, IPipeScrollModel
    {
        public float ScrollSpeed { get; private set; } = 1f;
    }
}
