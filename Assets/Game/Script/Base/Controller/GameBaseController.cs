using Agate.MVC.Base;

namespace FlappyBird.Base.MVC
{
    public abstract class GameBaseController<TController> : BaseController<TController>
        where TController : BaseController<TController>
    { }
}
