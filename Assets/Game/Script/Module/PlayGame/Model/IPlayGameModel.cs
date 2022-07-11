using FlappyBird.Base.MVC;

namespace FlappyBird.Module.PlayGame
{
    public interface IPlayGameModel : IGameBaseModel
    {
        public bool IsPlaying { get; }
    }
}
