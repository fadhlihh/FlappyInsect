using UnityEngine;

using Game.Base.MVC;
using Game.Module.Input;

namespace Game.Module.Pipe
{
    public class PipeScrollConnector : GameConnector
    {
        private PipeScrollController _pipeScroll;
        protected override void Connect()
        {
            Subscribe<TapStartMessage>(_pipeScroll.OnPlayGame);
        }

        protected override void Disconnect()
        {
            Unsubscribe<TapStartMessage>(_pipeScroll.OnPlayGame);
        }
    }
}
