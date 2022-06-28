using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdAddScoreView : GameBaseView
    {
        private UnityAction<Transform> _onAddScore;

        public void SetCallbacks(UnityAction<Transform> onAddScore)
        {
            _onAddScore = onAddScore;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            _onAddScore?.Invoke(other.transform);
        }
    }
}
