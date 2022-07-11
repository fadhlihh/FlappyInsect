using Agate.MVC.Base;

namespace FlappyBird.Base.MVC
{
    public abstract class GameObjectView<TModel> : ObjectView<TModel>
    where TModel : IGameBaseModel
    { }
}
