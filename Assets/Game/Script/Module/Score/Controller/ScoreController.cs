using Agate.MVC.Core;

using Game.Base.MVC;

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
