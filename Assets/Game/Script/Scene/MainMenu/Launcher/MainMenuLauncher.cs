using System.Collections;

using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using Game.Boot;
using Game.Utilty;
using Game.Module.Menu;
using Game.Module.HighScore;

namespace Game.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        [SerializeField]
        private MainMenuView _mainMenuView;

        private MenuController _menu;
        private HighScoreCounterController _highScoreCounter;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] { };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new MenuController()
            };
        }

        protected override string GetSceneName()
        {
            return GameScene.MainMenu;
        }

        protected override MainMenuView GetSceneView()
        {
            return _mainMenuView;
        }

        protected override IEnumerator InitSceneObject()
        {
            _menu.SetView(_mainMenuView.MenuView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
