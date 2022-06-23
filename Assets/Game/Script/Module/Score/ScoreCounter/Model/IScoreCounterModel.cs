using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Score
{
    public interface IScoreCounterModel : IGameBaseModel
    {
        public int Score { get; }
    }
}
