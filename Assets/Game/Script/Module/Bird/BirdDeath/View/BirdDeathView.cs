using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdDeathView : GameBaseView
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
    }
}
