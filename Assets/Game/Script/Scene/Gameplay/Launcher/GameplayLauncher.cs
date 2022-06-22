using System.Collections;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using Game.Boot;
using Game.Utilty;

using Game.Module.Input;
using Game.Module.PlayGame;

namespace Game.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        [SerializeField]
        private GameplayView _gameplayView;

        private PlayGameController _playGame;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new PlayGameConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new TapInputController(),
                new PlayGameController()
        };
        }

        protected override string GetSceneName()
        {
            return GameScene.GamePlay;
        }

        protected override GameplayView GetSceneView()
        {
            return _gameplayView;
        }

        protected override IEnumerator InitSceneObject()
        {
            _playGame.SetView(_view.PlayGameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
