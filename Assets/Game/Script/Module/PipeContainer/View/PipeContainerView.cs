using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Game.Base.MVC;

namespace Game.Module.PipeContainer
{
    public class PipeContainerView : GameObjectView<IPipeContainerModel>
    {
        private UnityAction _onSpawnPipe;
        private UnityAction _onMovePosition;
        private UnityAction _onDespawnPipe;

        public void SetCallbacks(UnityAction onSpawnPipe, UnityAction onMovePosition, UnityAction onDespawnPipe)
        {
            _onSpawnPipe = onSpawnPipe;
            _onMovePosition = onMovePosition;
            _onDespawnPipe = onDespawnPipe;
        }

        protected override void InitRenderModel(IPipeContainerModel model)
        {
            transform.position = model.Position;
            if (model.IsPlaying)
            {
                StartCoroutine(InvokeSpawn(model.SpawnRate));
            }
        }

        protected override void UpdateRenderModel(IPipeContainerModel model)
        {
            if (model.IsPlaying)
            {
                StartCoroutine(InvokeSpawn(model.SpawnRate));
                transform.position = model.Position;
            }
        }

        private void Update()
        {
            _onMovePosition?.Invoke();
            _onDespawnPipe?.Invoke();
        }

        private IEnumerator InvokeSpawn(float delayTime)
        {
            yield return new WaitForSeconds(delayTime);
            _onSpawnPipe?.Invoke();
        }
    }
}
