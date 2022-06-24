using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.HighScore
{
    public interface IHighScoreModel : IGameBaseModel
    {
        public int HighScore { get; }
    }
}
