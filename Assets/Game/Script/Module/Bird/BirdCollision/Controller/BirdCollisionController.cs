using UnityEngine;

using Game.Base.MVC;
using Game.Module.HighScore;
using Game.Module.Score;
using Game.Module.Bird;

namespace Game.Module.Bird
{
    public class BirdCollisionController : GameObjectController<BirdCollisionController, BirdCollisionView>
    {
        public override void SetView(BirdCollisionView view)
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
                Publish<GameOverMessage>(new GameOverMessage());
            }
            else if (collision.CompareTag("Hole"))
            {
                bool isTroughPipeHole = collision.CompareTag("Hole");
                if (isTroughPipeHole)
                {
                    Publish<AddScoreMessage>(new AddScoreMessage());
                }
            }
        }
    }
}
