using UnityEngine;
using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;

namespace FlappyBird.Module.Bird
{
    public class BirdMovementController : GameDataController<BirdMovementController, BirdMovementModel>
    {
        private Rigidbody2D _birdPhysics;

        public void OnStartPlay(StartPlayMessage message)
        {
            _birdPhysics.gravityScale = _model.GravityScale;
        }

        public void OnMoveBird(MoveBirdMessage message)
        {
            Vector2 force = Vector2.up * _model.Force * Time.fixedDeltaTime;
            _birdPhysics.AddForce(force, ForceMode2D.Force);
        }

        public void SetBirdPhysics(Rigidbody2D birdPhysics)
        {
            _birdPhysics = birdPhysics;
        }
    }
}
