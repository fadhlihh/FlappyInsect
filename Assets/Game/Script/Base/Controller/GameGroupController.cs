using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameGroupController<TController> : GroupController<TController>
        where TController : GroupController<TController>
    { }
}
