using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameDataController<TController, TModel> : DataController<TController, TModel>
    where TController : DataController<TController, TModel>
    where TModel : BaseModel, new()
    { }
}
