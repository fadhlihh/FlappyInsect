using Agate.MVC.Core;
using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Bird
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
