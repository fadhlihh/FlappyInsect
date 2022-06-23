using UnityEngine;

using Agate.MVC.Base;

namespace Game.Base.MVC
{
    public abstract class GameObjectView<TModel> : ObjectView<TModel>
    where TModel : IGameBaseModel
    { }
}
