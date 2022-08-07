using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.InsectSelection
{
    public class InsectSelectionConnector : BaseConnector
    {
        private InsectSelectionController _insectSelection;

        protected override void Connect()
        {
            Subscribe<ShowInsectSelectionMessage>(_insectSelection.OnShowInsectSelection);
            Subscribe<InsectChangeMessage>(_insectSelection.OnInsectChange);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShowInsectSelectionMessage>(_insectSelection.OnShowInsectSelection);
            Unsubscribe<InsectChangeMessage>(_insectSelection.OnInsectChange);
        }
    }
}
