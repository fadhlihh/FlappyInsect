using System.Collections;
using FlappyBird.Base.MVC;
using FlappyBird.Boot;
using FlappyBird.Utilty;
using FlappyBird.Module.Bird;
using FlappyBird.Module.HighScoreData;
using FlappyBird.Module.Score;

namespace FlappyBird.Module.GameOver
{
    public class GameOverController : GameObjectController<GameOverController, GameOverModel, IGameOverModel, GameOverView>
    {
        private HighScoreDataController _highScoreData;

        public void OnGameOver(GameOverMessage message)
        {
            _view.SetCallbacks(OnRestart, OnToMainMenu);
            _view.ShowGameOverPopUp();
        }

        public void OnShowCalcScore(ShowCalcScoreMessage message)
        {
            _model.SetScore(message.Score);
            _model.SetHighScore(message.HighScore);
        }

        private void OnRestart()
        {
            SceneLoader.Instance.RestartScene();
        }

        private void OnToMainMenu()
        {
            SceneLoader.Instance.LoadScene(GameScene.MainMenu);
        }
    }
}
