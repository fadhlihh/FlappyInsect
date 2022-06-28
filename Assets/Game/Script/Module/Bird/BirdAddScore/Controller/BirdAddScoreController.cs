using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdAddScoreController : GameObjectController<BirdAddScoreController, BirdAddScoreView>
    {
        public override void SetView(BirdAddScoreView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnAddScore);
        }

        public void OnAddScore(Transform collision)
        {
            bool isTroughPipeHole = collision.CompareTag("Hole");
            if (isTroughPipeHole)
            {
                Publish<BirdAddScoreMessage>(new BirdAddScoreMessage());
            }
        }
    }
}
