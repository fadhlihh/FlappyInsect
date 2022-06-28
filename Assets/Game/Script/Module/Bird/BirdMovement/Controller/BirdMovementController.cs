using UnityEngine;

using Game.Base.MVC;
using Game.Module.Input;
using System.Collections;

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
            _birdPhysics.AddForce(Vector2.up * _model.Force * Time.fixedDeltaTime, ForceMode2D.Force);
        }
        public void GetBirdPhysics(Rigidbody2D birdPhysics)
        {
            _birdPhysics = birdPhysics;
        }
    }
}
