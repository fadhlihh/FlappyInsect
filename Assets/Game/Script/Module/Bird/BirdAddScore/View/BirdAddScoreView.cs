using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Bird
{
    public class BirdAddScoreView : GameBaseView
    {
        UnityAction<Transform> _onAddScore;

        public void Init(UnityAction<Transform> onAddScore)
        {
            _onAddScore = onAddScore;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Collision");
            _onAddScore?.Invoke(other.transform);
        }
    }
}
