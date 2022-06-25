using UnityEngine;

using Game.Base.MVC;

using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Pipe
{
    public class PipeScrollController : GameObjectController<PipeScrollController, PipeScrollModel, IPipeScrollModel, PipeScrollView>
    {
        public void OnPlayGame(TapStartMessage message)
        {
            _model.SetIsPlaying(true);
            _view.SetCallbacks(OnMovePosition);
        }

        public void OnMovePosition()
        {
            if (_model.IsPlaying)
            {
                Vector3 position = _model.Position + (Vector3.left * _model.ScrollSpeed * Time.deltaTime);
                _model.SetPosition(position);
            }
        }

        public void OnGameOver(BirdDeathMessage message)
        {
            _model.SetIsPlaying(false);
        }
    }
}
