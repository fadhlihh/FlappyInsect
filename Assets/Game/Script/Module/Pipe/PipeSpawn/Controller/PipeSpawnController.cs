using UnityEngine;

using System.Threading.Tasks;

using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Pipe
{
    public class PipeSpawnController : GameDataController<PipeSpawnController, PipeSpawnModel>
    {
        private PipeScrollController _pipeScroll;
        public async void OnPlayGame(TapStartMessage message)
        {
            _model.SetIsPlaying(true);
            while (_model.IsPlaying)
            {
                GameObject pipe = Object.Instantiate(Resources.Load("Prefabs/Pipe/Pipe")) as GameObject;
                pipe.transform.SetParent(_pipeScroll.View.transform);
                Vector3 pipeYPosition = Vector3.up * Random.Range(_model.MinYSpawnPoint, _model.MaxYSpawnPoint);
                pipe.transform.localPosition = _model.SpawnPoint + pipeYPosition;
                _model.MoveSpawnPoint();
                await Task.Delay(_model.SpawnDelay);
            }
        }

        public void OnGameOver(BirdDeathMessage message)
        {
            _model.SetIsPlaying(false);
        }
    }
}
