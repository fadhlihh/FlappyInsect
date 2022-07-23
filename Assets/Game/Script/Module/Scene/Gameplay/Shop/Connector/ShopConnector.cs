using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.Shop
{
    public class ShopConnector : BaseConnector
    {
        private ShopController _shop;
        protected override void Connect()
        {
            Subscribe<ShowShopMessage>(_shop.OnShowShop);
            Subscribe<PurchaseInsectMessage>(_shop.OnPurchaseInsect);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShowShopMessage>(_shop.OnShowShop);
            Unsubscribe<PurchaseInsectMessage>(_shop.OnPurchaseInsect);
        }
    }
}
