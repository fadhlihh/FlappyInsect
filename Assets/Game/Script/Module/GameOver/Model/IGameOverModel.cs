using FlappyBird.Base.MVC;

namespace FlappyBird.Module.GameOver
{
    public interface IGameOverModel : IGameBaseModel
    {
        public int Score { get; }
        public int HighScore { get; }
    }
}
