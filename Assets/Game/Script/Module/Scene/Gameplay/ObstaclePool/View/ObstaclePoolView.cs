using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace FlappyInsect.Module.ObstaclePool
{
    public class ObstaclePoolView : ObjectView<IObstaclePoolModel>
    {
        private UnityAction _onMovePosition;
        private UnityAction _onDespawnObstacle;

        public void SetCallbacks(UnityAction onMovePosition, UnityAction onDespawnObstacle)
        {
            _onMovePosition = onMovePosition;
            _onDespawnObstacle = onDespawnObstacle;
        }

        protected override void InitRenderModel(IObstaclePoolModel model)
        {
            transform.position = _model.Position;
        }

        protected override void UpdateRenderModel(IObstaclePoolModel model)
        {
            transform.position = _model.Position;
        }

        private void Update()
        {
            _onMovePosition?.Invoke();
            _onDespawnObstacle?.Invoke();
        }
    }
}
