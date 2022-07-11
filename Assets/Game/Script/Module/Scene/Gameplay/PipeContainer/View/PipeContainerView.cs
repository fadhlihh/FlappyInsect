using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using FlappyBird.Base.MVC;

namespace FlappyBird.Module.PipeContainer
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
