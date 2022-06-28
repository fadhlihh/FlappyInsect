using UnityEngine;
using UnityEngine.SceneManagement;

using Game.Base.MVC;
using Game.Boot;
using Game.Utilty;

using Game.Module.Bird;
using Game.Module.HighScore;

namespace Game.Module.GameOver
{
    public class GameOverPopUpController : GameObjectController<GameOverPopUpController, GameOverPopUpModel, IGameOverPopUpModel, GameOverPopUpView>
    {
        public void OnGameOver(BirdDeathMessage message)
        {
            _model.SetScore(message.Score);
            _model.SetHighScore(message.HighScore);
            _view.SetCallbacks(OnRestart, OnToMainMenu);
            _view.ShowGameOverPopUp();
        }

        public void OnUpdateHighScore(UpdateHighScoreMessage message)
        {
            _model.SetHighScore(message.HighScore);
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
