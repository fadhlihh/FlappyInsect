using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameObjectController<TController, TView> : ObjectController<TController, TView>
        where TController : ObjectController<TController, TView>
        where TView : BaseView
    { }
    public abstract class GameObjectController<TController, TModel, TInterfaceModel, TView> : ObjectController<TController, TModel, TInterfaceModel, TView>
        where TController : ObjectController<TController, TModel, TInterfaceModel, TView>
        where TModel : GameBaseModel, TInterfaceModel, new()
        where TInterfaceModel : IGameBaseModel
        where TView : GameObjectView<TInterfaceModel>
    { }
}
