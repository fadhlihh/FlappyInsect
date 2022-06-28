using UnityEngine;

using Game.Base.MVC;
using Game.Module.Score;
using Game.Module.HighScore;

namespace Game.Module.Bird
{
    public class BirdDeathController : GameObjectController<BirdDeathController, BirdDeathView>
    {
        private ScoreCounterController _scoreCounter;
        private HighScoreCounterController _highScoreCounter;
        public override void SetView(BirdDeathView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnGameOver);
        }

        public void OnGameOver(Transform collision)
        {
            if (collision.CompareTag("Ground") || collision.CompareTag("Pipe"))
            {
                Component.Destroy(_view.GetComponent<CircleCollider2D>());
                _highScoreCounter.CheckHighScore(_scoreCounter.Model.Score);
                Publish<BirdDeathMessage>(new BirdDeathMessage(_scoreCounter.Model.Score, _highScoreCounter.Model.HighScore));
            }
        }
    }
}
