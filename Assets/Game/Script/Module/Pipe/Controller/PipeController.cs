using Agate.MVC.Core;

using Game.Base.MVC;

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
