using UnityEngine;

using Game.Base.MVC;
using Agate.MVC.Core;

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
