using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeDespawnController : GameObjectController<PipeDespawnController, PipeDespawnView>
    {
        public override void SetView(PipeDespawnView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnDespawnPipe);
        }

        private void OnDespawnPipe(Transform collision)
        {
            bool isCollideWithPipe = collision.CompareTag("Pipe");
            if (isCollideWithPipe)
            {
                Object.Destroy(collision.gameObject);
            }
        }
    }
}
