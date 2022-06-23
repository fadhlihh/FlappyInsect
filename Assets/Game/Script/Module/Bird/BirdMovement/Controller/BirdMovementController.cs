using UnityEngine;

using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.Bird
{
    public class BirdMovementController : GameObjectController<BirdMovementController, BirdMovementModel, IBirdMovementModel, BirdMovementView>
    {
        public void OnTapStart(TapStartMessage message)
        {
            _view.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        }
        public void OnMoveBird(TapMessage message)
        {
            _view.GetComponent<Rigidbody2D>().AddForce(Vector2.up * _model.Force * Time.fixedDeltaTime, ForceMode2D.Force);
        }
    }
}
