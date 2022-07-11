using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using FlappyBird.Boot;
using FlappyBird.Utilty;
using FlappyBird.Module.Menu;

namespace FlappyBird.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        private MenuController _menu;

        public override string SceneName { get { return GameScene.MainMenu; } }

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

        protected override IEnumerator InitSceneObject()
        {
            _menu.SetView(_view.MenuView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
