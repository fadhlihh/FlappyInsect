using UnityEngine;
using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.PipeContainer
{
    public class PipeContainerController : GameObjectController<PipeContainerController, PipeContainerModel, IPipeContainerModel, PipeContainerView>
    {
        public void SetInitPosition(Camera mainCamera)
        {
            Vector3 worldPointPosition = mainCamera.ViewportToWorldPoint(_model.Position);
            _model.SetPosition(worldPointPosition);
            Vector3 worldPointDespawnPosition = mainCamera.ViewportToWorldPoint(_model.DespawnPosition);
            _model.SetDespawnPosition(worldPointDespawnPosition);
        }

        public void OnStartPlay(StartPlayMessage message)
        {
            _model.SetIsPlaying(true);
            _view.SetCallbacks(OnSpawnPipe, OnMovePosition, OnDespawnPipe);
        }

        public void OnGameOver(GameOverMessage message)
        {
            _model.SetIsPlaying(false);
        }

        private void OnSpawnPipe()
        {
            GameObject pipe = Object.Instantiate(Resources.Load("Prefabs/Pipe/Pipe")) as GameObject;
            pipe.transform.SetParent(_view.transform);
            Vector3 pipeYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);
            pipe.transform.localPosition = _model.SpawnPoint + pipeYPosition;
            _model.AddPipe(pipe);
            _model.MoveSpawnPoint();
        }

        private void OnMovePosition()
        {
            if (_model.IsPlaying)
            {
                Vector3 position = _model.Position + (Vector3.left * _model.ScrollSpeed * Time.deltaTime);
                _model.SetPosition(position);
                _view.transform.position = _model.Position;
            }
        }

        private void OnDespawnPipe()
        {
            if (_model.Pipes.Count > 0)
            {
                float frontPipePosition = _model.Pipes.Peek().transform.position.x;
                float despawnPosition = _model.DespawnPosition.x;
                if (frontPipePosition <= despawnPosition)
                {
                    GameObject pipe = _model.GetPipe();
                    Object.Destroy(pipe);
                }
            }
        }
    }
}
