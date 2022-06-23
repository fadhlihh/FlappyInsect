using UnityEngine;

using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.Pipe
{
    public class PipeSpawnConnector : GameConnector
    {
        private PipeSpawnController _pipeSpawn;
        protected override void Connect()
        {
            Subscribe<TapStartMessage>(_pipeSpawn.OnPlayGame);
        }

        protected override void Disconnect()
        {
            Unsubscribe<TapStartMessage>(_pipeSpawn.OnPlayGame);
        }
    }
}
