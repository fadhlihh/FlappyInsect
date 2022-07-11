using UnityEngine;
using UnityEngine.Events;
using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Bird
{
    public class BirdCollisionView : GameBaseView
    {
        private UnityAction<Transform> _onBirdCollide;

        public void SetCallbacks(UnityAction<Transform> onBirdCollide)
        {
            _onBirdCollide = onBirdCollide;
        }

        private void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            _onBirdCollide?.Invoke(collisionInfo.transform);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            _onBirdCollide?.Invoke(other.transform);
        }
    }
}
