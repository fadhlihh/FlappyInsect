using System.Collections;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using Game.Module.HighScore;
using Game.Module.SaveData;

namespace Game.Boot
{
    public class GameLauncher : BaseMain<GameLauncher>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]{
                new HighScoreConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[] {
                new SaveDataController(),
                new HighScoreController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }

}
