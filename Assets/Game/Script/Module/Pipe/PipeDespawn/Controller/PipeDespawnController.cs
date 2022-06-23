using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeDespawnController : GameObjectController<PipeDespawnController, PipeDespawnView>
    {
        public override void SetView(PipeDespawnView view)
        {
            base.SetView(view);
            view.Init(OnDespawnPipe);
        }

        public void OnDespawnPipe(Transform collision)
        {
            if (collision.CompareTag("Pipe"))
            {
                Object.Destroy(collision.gameObject);
            }
        }
    }
}
