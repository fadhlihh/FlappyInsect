using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.InsectsData;
using FlappyInsect.Module.ProgressData;
using FlappyInsect.Module.ShopItem;

namespace FlappyInsect.Module.Shop
{
    public class ShopController : ObjectController<ShopController, ShopModel, IShopModel, ShopView>
    {
        private InsectsDataController _insectData;
        private ProgressDataController _progressData;

        public override void SetView(ShopView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnShowShopItem);
            _model.SetModelData(_progressData.Model.Progress.Coin, _insectData.Model.InsectData.Insects, _progressData.Model.Progress.Insects);
        }

        public void OnShowShop(ShowShopMessage message)
        {
            _view.Show();
        }

        public void OnPurchaseInsect(int cost)
        {
            int totalCoin = _model.TotalCoin - cost;
            _model.SetTotalCoin(totalCoin);
            _model.SetCollectedInsect(_progressData.Model.Progress.Insects);
        }

        public void OnShowShopItem()
        {
            if (_model.ShopItemCount <= 0)
            {
                CreateShopItem();
            }
            else
            {
                UpdateShopItem();
            }
        }

        private void CreateShopItem()
        {
            foreach (InsectData insect in _model.Insects)
            {
                bool isSold = _model.CollectedInsects.Exists(item => string.Equals(item.Name, insect.Name));
                bool isCostAffordable = insect.Cost <= _model.TotalCoin;
                ShopItemModel itemModel = new ShopItemModel(insect.Name, insect.Cost, isSold, isCostAffordable);
                GameObject itemObject = _view.CreateItemObject(itemModel.Name);
                ShopItemView itemView = itemObject.GetComponent<ShopItemView>();
                ShopItemController shopItem = new ShopItemController();
                InjectDependencies(shopItem);
                shopItem.Init(itemModel, itemView);
                _model.AddShopItem(shopItem);
            }
        }

        private void UpdateShopItem()
        {
            foreach (InsectData insect in _model.Insects)
            {
                bool isSold = _model.CollectedInsects.Exists(item => string.Equals(item.Name, insect.Name));
                bool isCostAffordable = insect.Cost <= _model.TotalCoin;
                ShopItemController insectSelectionItem = _model.FindShopItem(insect.Name);
                insectSelectionItem.UpdateModelData(insect.Name, insect.Cost, isSold, isCostAffordable);
            }
        }
    }
}
