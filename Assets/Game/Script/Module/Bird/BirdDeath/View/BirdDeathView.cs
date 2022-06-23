using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdDeathView : GameBaseView
    {
        UnityAction<Transform> _onBirdCollide;
        public void Init(UnityAction<Transform> onBirdCollide)
        {
            _onBirdCollide = onBirdCollide;
        }
        void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            _onBirdCollide?.Invoke(collisionInfo.transform);
        }
    }
}
