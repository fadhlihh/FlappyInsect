using UnityEngine;

using Game.Base.MVC;
using Agate.MVC.Core;

namespace Game.Module.Score
{
    public class ScoreController : GameGroupController<ScoreController>
    {
        protected override IController[] GetSubControllers()
        {
            return new IController[]{
                new ScoreCounterController(),
                new AddScoreAudioController()
            };
        }
    }
}
