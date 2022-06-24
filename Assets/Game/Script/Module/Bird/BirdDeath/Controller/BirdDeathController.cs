using UnityEngine;

using Game.Base.MVC;
using Game.Module.Score;

namespace Game.Module.Bird
{
    public class BirdDeathController : GameObjectController<BirdDeathController, BirdDeathView>
    {
        private ScoreCounterController _scoreCounter;
        public override void SetView(BirdDeathView view)
        {
            base.SetView(view);
            view.Init(OnGameOver);
        }

        public void OnGameOver(Transform collision)
        {
            if (collision.CompareTag("Ground") || collision.CompareTag("Pipe"))
            {
                Publish<BirdDeathMessage>(new BirdDeathMessage(_scoreCounter.Model.Score));
            }
        }
    }
}
