using UnityEngine;
using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Bird
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
            bool isTroughPipeHole = collision.CompareTag("Hole");
            if (isCollideWithGround || isCollideWithPipe)
            {
                _view.GetComponent<CircleCollider2D>().enabled = false;
                Publish<GameOverMessage>(new GameOverMessage());
            }
            else if (isTroughPipeHole)
            {
                Publish<AddScoreMessage>(new AddScoreMessage());
            }
        }
    }
}
