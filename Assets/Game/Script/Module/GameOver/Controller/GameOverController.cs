using Agate.MVC.Core;

using Game.Base.MVC;

namespace Game.Module.GameOver
{
    public class GameOverController : GameGroupController<GameOverController>
    {
        protected override IController[] GetSubControllers()
        {
            return new IController[]{
                new GameOverPopUpController(),
                new GameOverAudioController()
            };
        }
    }
}
