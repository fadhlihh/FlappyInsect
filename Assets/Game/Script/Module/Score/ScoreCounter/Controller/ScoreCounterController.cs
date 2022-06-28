using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Score
{
    public class ScoreCounterController : GameObjectController<ScoreCounterController, ScoreCounterModel, IScoreCounterModel, ScoreCounterView>
    {
        public void OnTapStart(TapStartMessage message)
        {
            _view.ScoreText.gameObject.SetActive(true);
        }

        public void OnAddScore(BirdAddScoreMessage message)
        {
            _model.AddScore();
        }
    }
}
