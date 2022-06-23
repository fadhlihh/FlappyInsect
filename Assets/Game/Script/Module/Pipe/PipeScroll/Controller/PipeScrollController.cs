using UnityEngine;

using Game.Base.MVC;

using Game.Module.Input;

namespace Game.Module.Pipe
{
    public class PipeScrollController : GameObjectController<PipeScrollController, PipeScrollModel, IPipeScrollModel, PipeScrollView>
    {
        public PipeScrollView View
        {
            get
            {
                return _view;
            }
        }

        public void OnPlayGame(TapStartMessage message)
        {
            _view.Init(OnMovePosition);
        }

        public void OnMovePosition()
        {
            _view.transform.Translate(Vector3.left * _model.ScrollSpeed * Time.deltaTime);
        }
    }
}
