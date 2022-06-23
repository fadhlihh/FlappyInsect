using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeDespawnView : GameBaseView
    {
        private UnityAction<Transform> _onDespawnPipe;
        public void Init(UnityAction<Transform> onDespawnPipe)
        {
            _onDespawnPipe = onDespawnPipe;
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            _onDespawnPipe?.Invoke(other.transform);
        }
    }
}
