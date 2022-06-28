using Game.Base.MVC;

namespace Game.Module.Menu
{
    public interface IMenuModel : IGameBaseModel
    {
        public int HighScore { get; }
    }
}
