using Agate.MVC.Base;

namespace FlappyBird.Base.MVC
{
    public abstract class GameGroupController<TController> : GroupController<TController>
        where TController : GroupController<TController>
    { }
}
