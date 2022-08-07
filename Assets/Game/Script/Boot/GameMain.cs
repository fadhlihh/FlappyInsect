using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
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
            CreateEventSystem();
            Application.targetFrameRate = 60;
            yield return null;
        }

        private void CreateEventSystem()
        {
            GameObject eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<InputSystemUIInputModule>();
            GameObject.DontDestroyOnLoad(eventSystem);
        }
    }

}
