using Game.Base.MVC;
using Game.Module.HighScoreData;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Score
{
    public class ScoreController : GameObjectController<ScoreController, ScoreModel, IScoreModel, ScoreView>
    {
        private HighScoreDataController _highScoreData;

        public void OnStartPlay(StartPlayMessage message)
        {
            _view.ScoreText.gameObject.SetActive(true);
        }

        public void OnAddScore(AddScoreMessage message)
        {
            _model.AddScore();
        }

        public void OnGameOver(GameOverMessage message)
        {
            CheckHighScore();
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model.Score));
        }

        public void CheckHighScore()
        {
            if (_model.Score > _highScoreData.Model.HighScore)
            {
                _highScoreData.Save(_model.Score);
            }
        }
    }
}
