using System.Collections;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using Game.Boot;
using Game.Utilty;

using Game.Module.Input;
using Game.Module.PlayGame;
using Game.Module.PipeContainer;
using Game.Module.Bird;
using Game.Module.Score;
using Game.Module.GameOver;
using Game.Module.Audio;

namespace Game.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private PlayGameController _playGame;
        private PipeContainerController _pipeContainer;
        private BirdMovementController _birdMovement;
        private BirdCollisionController _birdCollision;
        private ScoreController _scoreCounter;
        private GameOverController _gameOverPopUp;

        public override string SceneName { get { return GameScene.GamePlay; } }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new TapInputConnector(),
                new PlayGameConnector(),
                new PipeContainerConnector(),
                new BirdMovementConnector(),
                new ScoreConnector(),
                new GameOverConnector(),
                new GameplayAudioConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new TapInputController(),
                new PlayGameController(),
                new PipeContainerController(),
                new BirdController(),
                new ScoreController(),
                new GameOverController(),
                new GameplayAudioController()
        };
        }

        protected override IEnumerator InitSceneObject()
        {
            _playGame.SetView(_view.PlayGameView);
            _pipeContainer.SetView(_view.PipeContainerView);
            _pipeContainer.SetInitPosition(_view.MainCamera);
            _birdMovement.SetBirdPhysics(_view.BirdPhysics);
            _birdCollision.SetView(_view.BirdCollisionView);
            _scoreCounter.SetView(_view.ScoreCounterView);
            _gameOverPopUp.SetView(_view.GameOverView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
