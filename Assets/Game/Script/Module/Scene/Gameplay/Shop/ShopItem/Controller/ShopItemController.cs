using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ShopItem
{
    public class ShopItemController : ObjectController<ShopItemController, ShopItemModel, IShopItemModel, ShopItemView>
    {
        public override void SetView(ShopItemView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnPurchase);
        }

        public void Init(ShopItemModel model, ShopItemView view)
        {
            _model = model;
            SetView(view);
        }

        public void UpdateModelData(string name, int cost, bool isSold, bool isCostAffordable)
        {
            _model.SetModelData(name, cost, isSold, isCostAffordable);
        }

        private void OnPurchase()
        {
            Publish<PurchaseInsectMessage>(new PurchaseInsectMessage(_model.Name, _model.Cost));
        }
    }
}
