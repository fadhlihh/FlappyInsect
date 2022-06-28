using UnityEngine;

using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.Bird
{
    public class BirdMovementController : GameDataController<BirdMovementController, BirdMovementModel>
    {
        private Rigidbody2D _birdPhysics;

        public void OnTapStart(TapStartMessage message)
        {
            _birdPhysics.gravityScale = _model.GravityScale;
        }

        public void OnMoveBird(TapMessage message)
        {
            Vector2 force = Vector2.up * _model.Force * Time.fixedDeltaTime;
            _birdPhysics.AddForce(force, ForceMode2D.Force);
        }

        public void GetBirdPhysics(Rigidbody2D birdPhysics)
        {
            _birdPhysics = birdPhysics;
        }
    }
}
