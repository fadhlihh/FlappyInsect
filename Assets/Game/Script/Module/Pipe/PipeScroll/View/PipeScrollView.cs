using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeScrollView : GameObjectView<IPipeScrollModel>
    {
        private UnityAction _onMovePosition;

        public void SetCallbacks(UnityAction onMovePosition)
        {
            _onMovePosition = onMovePosition;
        }

        private void Update()
        {
            _onMovePosition?.Invoke();
        }

        protected override void InitRenderModel(IPipeScrollModel model)
        {
            transform.position = model.Position;
        }

        protected override void UpdateRenderModel(IPipeScrollModel model)
        {
            if (model.IsPlaying)
            {
                transform.position = model.Position;
            }
        }
    }
}
