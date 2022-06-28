using Game.Base.MVC;
using Game.Module.Input;
using Game.Module.Bird;

namespace Game.Module.Pipe
{
    public class PipeSpawnConnector : GameConnector
    {
        private PipeSpawnController _pipeSpawn;

        protected override void Connect()
        {
            Subscribe<TapStartMessage>(_pipeSpawn.OnPlayGame);
            Subscribe<BirdDeathMessage>(_pipeSpawn.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<TapStartMessage>(_pipeSpawn.OnPlayGame);
            Unsubscribe<BirdDeathMessage>(_pipeSpawn.OnGameOver);
        }
    }
}
