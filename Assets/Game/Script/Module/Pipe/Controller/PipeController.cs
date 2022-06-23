using UnityEngine;

using Game.Base.MVC;
using Agate.MVC.Core;

namespace Game.Module.Pipe
{
    public class PipeController : GameGroupController<PipeController>
    {
        protected override IController[] GetSubControllers()
        {
            return new IController[]{
                new PipeScrollController(),
                new PipeSpawnController(),
                new PipeDespawnController()
            };
        }
    }
}
