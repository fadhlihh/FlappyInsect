using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using FlappyInsect.Boot;
using FlappyInsect.Utilty;
using FlappyInsect.Module.Input;
using FlappyInsect.Module.HUD;
using FlappyInsect.Module.Shop;
using FlappyInsect.Module.InsectSelection;
using FlappyInsect.Module.GameSetting;
using FlappyInsect.Module.GamePause;
using FlappyInsect.Module.ObstaclePool;
using FlappyInsect.Module.Insect;
using FlappyInsect.Module.Coin;
using FlappyInsect.Module.CoinPool;
using FlappyInsect.Module.CoinCalculator;
using FlappyInsect.Module.ScoreCalculator;
using FlappyInsect.Module.GameOver;
using FlappyInsect.Module.GameplayAudio;

namespace FlappyInsect.Scene.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private HUDController _hud;
        private InsectSelectionController _insectSelection;
        private ShopController _shop;
        private GameSettingController _gameSetting;
        private GamePauseController _gamePause;
        private ObstaclePoolController _obstaclePool;
        private InsectController _insect;
        private CoinPoolController _coinPool;
        private GameOverController _gameOverPopUp;
        private GameplayAudioController _gameplayAudio;

        public override string SceneName { get { return GameScene.GamePlay; } }

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[] {
                new TapInputConnector(),
                new HUDConnector(),
                new ShopConnector(),
                new InsectSelectionConnector(),
                new GameSettingConnector(),
                new GamePauseConnector(),
                new ObstaclePoolConnector(),
                new InsectConnector(),
                new CoinPoolConnector(),
                new CoinCalculatorConnector(),
                new ScoreCalculatorConnector(),
                new GameOverConnector(),
                new GameplayAudioConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[] {
                new TapInputController(),
                new HUDController(),
                new ShopController(),
                new InsectSelectionController(),
                new GameSettingController(),
                new GamePauseController(),
                new ObstaclePoolController(),
                new InsectController(),
                new CoinController(),
                new ScoreCalculatorController(),
                new GameOverController(),
                new GameplayAudioController()
        };
        }

        protected override IEnumerator InitSceneObject()
        {
            _hud.SetView(_view.HUDView);
            _obstaclePool.SetView(_view.ObstaclePoolView);
            _insectSelection.SetView(_view.InsectSelectionView);
            _shop.SetView(_view.ShopView);
            _gameSetting.SetView(_view.GameSettingView);
            _gamePause.SetView(_view.GamePauseView);
            _insect.SetView(_view.InsectView);
            _coinPool.SetView(_view.CoinPoolView);
            _gameOverPopUp.SetView(_view.GameOverView);
            _gameplayAudio.SetView(_view.GameplayAudioView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
