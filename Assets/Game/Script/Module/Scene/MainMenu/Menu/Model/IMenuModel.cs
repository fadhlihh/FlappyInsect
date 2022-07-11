using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Menu
{
    public interface IMenuModel : IGameBaseModel
    {
        public int HighScore { get; }
    }
}
