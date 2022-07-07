using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
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
