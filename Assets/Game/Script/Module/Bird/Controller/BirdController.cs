using Game.Base.MVC;
using Agate.MVC.Core;

namespace Game.Module.Bird
{
    public class BirdController : GameGroupController<BirdController>
    {
        protected override IController[] GetSubControllers()
        {
            return new IController[]{
                new BirdMovementController(),
                new BirdCollisionController()
            };
        }
    }
}
