using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameObjectController<TController, TView> : ObjectController<TController, TView>
        where TController : ObjectController<TController, TView>
        where TView : BaseView
    { }
}
