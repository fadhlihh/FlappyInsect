using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.Insect
{
    public class InsectConnector : BaseConnector
    {
        private InsectController _insect;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_insect.OnStartPlay);
            Subscribe<MoveInsectMessage>(_insect.OnMoveInsect);
            Subscribe<InsectChangeMessage>(_insect.OnInsectChange);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_insect.OnStartPlay);
            Unsubscribe<MoveInsectMessage>(_insect.OnMoveInsect);
            Unsubscribe<InsectChangeMessage>(_insect.OnInsectChange);
        }
    }
}
