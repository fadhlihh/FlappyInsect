using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdDeathController : GameObjectController<BirdDeathController, BirdDeathView>
    {
        public override void SetView(BirdDeathView view)
        {
            base.SetView(view);
            view.Init(OnGameOver);
        }

        public void OnGameOver(Transform collision)
        {
            if (collision.CompareTag("Ground") || collision.CompareTag("Pipe"))
            {
                Publish<BirdDeathMessage>(new BirdDeathMessage());
            }
        }
    }
}
