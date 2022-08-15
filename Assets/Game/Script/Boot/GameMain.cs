using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using FlappyInsect.Module.InsectsData;
using FlappyInsect.Module.ProgressData;
using FlappyInsect.Module.ConfigData;
using FlappyInsect.Module.GameAudio;

namespace FlappyInsect.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]{
                new ConfigDataConnector(),
                new GameAudioConnector(),
                new ProgressDataConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[] {
                new InsectsDataController(),
                new ProgressDataController(),
                new ConfigDataController(),
                new GameAudioController()
            };
        }

        protected override IEnumerator StartInit()
        {
            Application.targetFrameRate = 60;
            yield return null;
        }
    }

}
