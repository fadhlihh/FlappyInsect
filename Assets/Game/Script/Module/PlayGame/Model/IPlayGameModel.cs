using Game.Base.MVC;

namespace Game.Module.PlayGame
{
    public interface IPlayGameModel : IGameBaseModel
    {
        public bool IsPlaying { get; }
    }
}
