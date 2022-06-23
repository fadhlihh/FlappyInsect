using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameBaseController<TController> : BaseController<TController>
        where TController : BaseController<TController>
    { }
}
