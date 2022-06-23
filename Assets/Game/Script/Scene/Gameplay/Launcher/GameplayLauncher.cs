using System.Collections;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;

using Game.Boot;
using Game.Utilty;

using Game.Module.Input;
using Game.Module.PlayGame;
using Game.Module.Pipe;
using Game.Module.Bird;
using Game.Module.Score;

namespace Game.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        [SerializeField]
        private GameplayView _gameplayView;

        private PlayGameController _playGame;
        private PipeScrollController _pipeScroll;
        private PipeDespawnController _pipeDespawn;
        private BirdMovementController _birdMovement;
        private BirdAddScoreController _birdAddScore;
        private BirdDeathController _birdDeath;
        private ScoreCounterController _scoreCounter;
        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new PlayGameConnector(),
                new PipeSpawnConnector(),
                new PipeScrollConnector(),
                new BirdMovementConnector(),
                new ScoreCounterConnector(),
                new AddScoreAudiConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new TapInputController(),
                new PlayGameController(),
                new PipeController(),
                new BirdController(),
                new ScoreController()
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
            _pipeScroll.SetView(_view.PipeScrollView);
            _pipeDespawn.SetView(_view.PipeDespawnView);
            _birdMovement.SetView(_view.BirdMovementView);
            _birdAddScore.SetView(_view.BirdAddScoreView);
            _birdDeath.SetView(_view.BirdDeathView);
            _scoreCounter.SetView(_view.ScoreCounterView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
