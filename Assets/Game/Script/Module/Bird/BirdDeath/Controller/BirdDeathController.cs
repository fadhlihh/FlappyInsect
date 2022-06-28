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
            bool isCollideWithGround = collision.CompareTag("Ground");
            bool isCollideWithPipe = collision.CompareTag("Pipe");
            if (isCollideWithGround || isCollideWithPipe)
            {
                _view.GetComponent<CircleCollider2D>().enabled = false;
                _highScoreCounter.CheckHighScore(_scoreCounter.Model.Score);
                Publish<BirdDeathMessage>(new BirdDeathMessage(_scoreCounter.Model.Score, _highScoreCounter.Model.HighScore));
            }
        }
    }
}
