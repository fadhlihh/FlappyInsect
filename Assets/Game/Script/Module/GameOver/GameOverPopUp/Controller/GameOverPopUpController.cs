using UnityEngine;
using UnityEngine.SceneManagement;

using Game.Base.MVC;
using Game.Boot;
using Game.Utilty;
using Game.Module.Bird;
using Game.Module.HighScore;

namespace Game.Module.GameOver
{
    public class GameOverPopUpController : GameObjectController<GameOverPopUpController, GameOverPopUpView>
    {
        private HighScoreCounterController _highScoreCounter;
        public void OnGameOver(BirdDeathMessage message)
        {
            _highScoreCounter.CheckHighScore(message.Score);
            _view.Init(message.Score, _highScoreCounter.Model.HighScore, OnRestart, OnToMainMenu);
        }

        public void OnRestart()
        {
            SceneLoader.Instance.RestartScene();
        }

        public void OnToMainMenu()
        {
            SceneManager.LoadScene(GameScene.MainMenu, LoadSceneMode.Additive);
        }
    }
}
