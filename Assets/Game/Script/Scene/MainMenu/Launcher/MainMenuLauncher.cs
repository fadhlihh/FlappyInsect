using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using FlappyInsect.Boot;
using FlappyInsect.Utilty;
using FlappyInsect.Module.Menu;
using FlappyInsect.Module.GameSetting;

namespace FlappyInsect.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        private MenuController _menu;
        private GameSettingController _gameSetting;

        public override string SceneName { get { return GameScene.MainMenu; } }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new GameSettingConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new MenuController(),
                new GameSettingController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _menu.SetView(_view.MenuView);
            _gameSetting.SetView(_view.GameSettingView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
