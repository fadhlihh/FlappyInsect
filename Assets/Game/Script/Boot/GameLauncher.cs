using System.Collections;

using Agate.MVC.Base;
using Agate.MVC.Core;

using Game.Module.HighScore;
using Game.Module.SaveData;

namespace Game.Boot
{
    public class GameLauncher : BaseMain<GameLauncher>, IMain
    {
        protected override IConnector[] GetMainConnectors()
        {
            return new IConnector[]{
            };
        }

        protected override IController[] GetSystemDependencies()
        {
            return new IController[] {
                new SaveDataController(),
                new HighScoreCounterController()
            };
        }

        protected override IEnumerator InitSystem()
        {
            yield return null;
        }
    }

}
