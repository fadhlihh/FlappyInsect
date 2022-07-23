using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ObstaclePool
{
    public class ObstaclePoolController : ObjectController<ObstaclePoolController, ObstaclePoolModel, IObstaclePoolModel, ObstaclePoolView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            SetInitPosition();
        }

        public override void SetView(ObstaclePoolView view)
        {
            base.SetView(view);
            InitPoolObject();
        }

        public void OnStartPlay(StartPlayMessage message)
        {
            _model.SetIsPlaying(true);
            _view.SetCallbacks(OnMovePosition, OnDespawnObstacle);
        }

        public void OnGameOver(GameOverMessage message)
        {
            _model.SetIsPlaying(false);
        }

        private void SetInitPosition()
        {
            Vector3 worldPointPosition = Camera.main.ViewportToWorldPoint(_model.Position);
            _model.SetPosition(worldPointPosition);
            Vector3 worldPointDespawnPosition = Camera.main.ViewportToWorldPoint(_model.DespawnPosition);
            _model.SetDespawnPosition(worldPointDespawnPosition);
        }

        private void InitPoolObject()
        {
            for (int i = 0; i < _model.PoolSize; i++)
            {
                GameObject obstaclePrefab = Resources.Load<GameObject>(@"Prefabs/Obstacle/Obstacle");
                GameObject obstacle = Object.Instantiate(obstaclePrefab, _view.transform);
                SpawnObstacle(obstacle);
            }
        }

        private void SpawnObstacle(GameObject obstacle)
        {
            Vector3 obstacleYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);
            obstacle.transform.localPosition = _model.SpawnPoint + obstacleYPosition;
            _model.MoveSpawnPoint();
            obstacle.SetActive(true);
            _model.EnqueueObstacle(obstacle);
        }

        private void OnMovePosition()
        {
            if (_model.IsPlaying)
            {
                Vector3 position = _model.Position + (Vector3.left * _model.ScrollSpeed * Time.deltaTime);
                _model.SetPosition(position);
            }
        }

        private void OnDespawnObstacle()
        {
            float frontObstaclePosition = _model.GetObstacleInFront().transform.position.x;
            float despawnPosition = _model.DespawnPosition.x;
            if (frontObstaclePosition <= despawnPosition)
            {
                GameObject obstacle = _model.DequeueObstacle();
                obstacle.SetActive(false);
                SpawnObstacle(obstacle);
            }
        }
    }
}
