using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Score
{
    public class ScoreController : GameObjectController<ScoreController, ScoreModel, IScoreModel, ScoreView>
    {
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
            Publish<UpdateScoreMessage>(new UpdateScoreMessage(_model.Score));
        }
    }
}
