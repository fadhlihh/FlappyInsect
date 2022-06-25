
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Pipe
{
    public class PipeSpawnView : GameObjectView<IPipeSpawnModel>
    {
        private UnityAction _onSpawnPipe;

        public void SetCallback(UnityAction onSpawnPipe)
        {
            _onSpawnPipe = onSpawnPipe;
        }

        private IEnumerator InvokeSpawn(float delayTime)
        {
            yield return new WaitForSeconds(delayTime);
            _onSpawnPipe?.Invoke();
        }

        protected override void InitRenderModel(IPipeSpawnModel model)
        {
            if (model.IsPlaying)
            {
                StartCoroutine(InvokeSpawn(model.SpawnRate));
            }
        }

        protected override void UpdateRenderModel(IPipeSpawnModel model)
        {
            if (model.IsPlaying)
            {
                StartCoroutine(InvokeSpawn(model.SpawnRate));
            }
        }
    }
}
