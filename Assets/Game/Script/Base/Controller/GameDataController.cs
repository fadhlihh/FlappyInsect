using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameDataController<TController, TModel> : DataController<TController, TModel>
    where TController : DataController<TController, TModel>
    where TModel : BaseModel, new()
    { }

    public abstract class GameDataController<TController, TModel, TInterfaceModel> : DataController<TController, TModel, TInterfaceModel>
    where TController : DataController<TController, TModel, TInterfaceModel>
    where TModel : BaseModel, TInterfaceModel, new()
    where TInterfaceModel : IBaseModel
    { }
}
