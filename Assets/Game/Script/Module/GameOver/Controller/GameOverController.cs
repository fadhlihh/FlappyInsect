using System.Collections;
using Game.Base.MVC;
using Game.Boot;
using Game.Utilty;
using Game.Module.Bird;
using Game.Module.HighScoreData;
using Game.Module.Score;

namespace Game.Module.GameOver
{
    public class GameOverController : GameObjectController<GameOverController, GameOverModel, IGameOverModel, GameOverView>
    {
        private ScoreController _score;
        private HighScoreDataController _highScoreData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetScore(_score.Model.Score);
            _model.SetHighScore(_highScoreData.Model.HighScore);
        }

        public void OnGameOver(GameOverMessage message)
        {
            _view.SetCallbacks(OnRestart, OnToMainMenu);
            _view.ShowGameOverPopUp();
        }

        public void OnUpdateHighScore(UpdateHighScoreMessage message)
        {
            _model.SetHighScore(message.HighScore);
        }

        public void OnUpdateScore(UpdateScoreMessage message)
        {
            _model.SetScore(message.Score);
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
