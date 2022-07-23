using System.Collections.Generic;
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
        private List<ShopItemController> _shopItemPool = new List<ShopItemController>();

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

        public void OnPurchaseInsect(PurchaseInsectMessage message)
        {
            int totalCoin = _model.TotalCoin - message.Cost;
            _model.SetTotalCoin(totalCoin);
            _progressData.SetTotalCoin(totalCoin);
            InsectData insect = _model.Insects.Find(item => string.Equals(message.Name, item.Name));
            _model.AddCollectedInsect(insect);
            _progressData.SaveProgress();
        }

        public void OnShowShopItem()
        {
            if (_shopItemPool.Count <= 0)
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
                _shopItemPool.Add(shopItem);
            }
        }

        private void UpdateShopItem()
        {
            foreach (InsectData insect in _model.Insects)
            {
                bool isSold = _model.CollectedInsects.Exists(item => string.Equals(item.Name, insect.Name));
                bool isCostAffordable = insect.Cost <= _model.TotalCoin;
                ShopItemController insectSelectionItem = _shopItemPool.Find(item => string.Equals(insect.Name, item.Model.Name));
                insectSelectionItem.UpdateModelData(insect.Name, insect.Cost, isSold, isCostAffordable);
            }
        }
    }
}
