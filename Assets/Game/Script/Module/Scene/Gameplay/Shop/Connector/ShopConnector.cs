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
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShowShopMessage>(_shop.OnShowShop);
        }
    }
}
