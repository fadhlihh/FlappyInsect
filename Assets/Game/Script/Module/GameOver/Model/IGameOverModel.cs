using Game.Base.MVC;

namespace Game.Module.GameOver
{
    public interface IGameOverModel : IGameBaseModel
    {
        public int Score { get; }
        public int HighScore { get; }
    }
}
