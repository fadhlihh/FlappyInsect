using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Boot;
using FlappyInsect.Utilty;
using FlappyInsect.Message;
using FlappyInsect.Module.ProgressData;
using FlappyInsect.Module.ScoreCalculator;
using FlappyInsect.Module.CoinCalculator;

namespace FlappyInsect.Module.GameOver
{
    public class GameOverController : ObjectController<GameOverController, GameOverModel, IGameOverModel, GameOverView>
    {
        private ProgressDataController _progressData;
        private ScoreCalculatorController _scoreCalculator;
        private CoinCalculatorController _coinCalculator;

        public void OnGameOver(GameOverMessage message)
        {
            _view.SetCallbacks(OnRestart, OnToMainMenu, OnToExitGame);
            _model.SetScore(_scoreCalculator.Model.Score);
            CheckHighScore(_model.Score);
            _model.SetHighScore(_progressData.Model.Progress.HighScore);
            _model.SetCoin(_coinCalculator.Model.Coin);
            int coin = _progressData.Model.Progress.Coin + _coinCalculator.Model.Coin;
            _progressData.SetTotalCoin(coin);
            _progressData.SaveProgress();
            _view.Show();
        }

        private void CheckHighScore(int score)
        {
            if (score > _progressData.Model.Progress.HighScore)
            {
                _progressData.SetNewHighScore(score);
            }
        }

        private void OnRestart()
        {
            SceneLoader.Instance.RestartScene();
        }

        private void OnToMainMenu()
        {
            SceneLoader.Instance.LoadScene(GameScene.MainMenu);
        }

        private void OnToExitGame()
        {
            Application.Quit();
        }
    }
}
