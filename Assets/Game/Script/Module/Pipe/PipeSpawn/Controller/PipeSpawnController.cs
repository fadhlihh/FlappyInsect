using UnityEngine;

using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Pipe
{
    public class PipeSpawnController : GameObjectController<PipeSpawnController, PipeSpawnModel, IPipeSpawnModel, PipeSpawnView>
    {
        public override void SetView(PipeSpawnView view)
        {
            base.SetView(view);
            view.SetCallback(OnSpawnPipe);
        }

        public void OnPlayGame(TapStartMessage message)
        {
            _model.SetIsPlaying(true);
        }

        public void OnGameOver(BirdDeathMessage message)
        {
            _model.SetIsPlaying(false);
        }

        private void OnSpawnPipe()
        {
            GameObject pipe = Object.Instantiate(Resources.Load("Prefabs/Pipe/Pipe")) as GameObject;
            pipe.transform.SetParent(_view.transform);
            Vector3 pipeYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);
            pipe.transform.localPosition = _model.SpawnPoint + pipeYPosition;
            _model.MoveSpawnPoint();
        }
    }
}
