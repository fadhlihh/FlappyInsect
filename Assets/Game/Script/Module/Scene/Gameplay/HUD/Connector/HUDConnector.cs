using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.HUD
{
    public class HUDConnector : BaseConnector
    {
        private HUDController _hud;
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_hud.OnStartPlay);
            Subscribe<UpdateScoreMessage>(_hud.OnUpdateScore);
            Subscribe<UpdateCoinMessage>(_hud.OnUpdateCoin);
            Subscribe<PurchaseInsectMessage>(_hud.OnPurchaseInsect);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_hud.OnStartPlay);
            Unsubscribe<UpdateScoreMessage>(_hud.OnUpdateScore);
            Unsubscribe<UpdateCoinMessage>(_hud.OnUpdateCoin);
            Unsubscribe<PurchaseInsectMessage>(_hud.OnPurchaseInsect);
        }
    }
}
