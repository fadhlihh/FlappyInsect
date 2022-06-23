using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdAddScoreController : GameObjectController<BirdAddScoreController, BirdAddScoreView>
    {
        public override void SetView(BirdAddScoreView view)
        {
            base.SetView(view);
            view.Init(OnAddScore);
        }

        public void OnAddScore(Transform collision)
        {
            if (collision.CompareTag("Hole"))
            {
                Publish<BirdAddScoreMessage>(new BirdAddScoreMessage());
                Debug.Log("Add Score");
            }
        }
    }
}
