using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.GameOver
{
    public interface IGameOverPopUpModel : IGameBaseModel
    {
        public int Score { get; }
        public int HighScore { get; }
    }
}
