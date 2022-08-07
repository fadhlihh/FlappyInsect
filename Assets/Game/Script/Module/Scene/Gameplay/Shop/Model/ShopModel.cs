using System.Collections.Generic;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;
using FlappyInsect.Module.ShopItem;

namespace FlappyInsect.Module.Shop
{
    public class ShopModel : BaseModel, IShopModel
    {
        private List<ShopItemController> _shopItemPool = new List<ShopItemController>();

        public int TotalCoin { get; private set; }
        public List<InsectData> CollectedInsects { get; private set; }
        public List<InsectData> Insects { get; private set; }
        public int ShopItemCount => _shopItemPool.Count;


        public void SetModelData(int totalCoin, List<InsectData> insects, List<InsectData> collectedInsects)
        {
            TotalCoin = totalCoin;
            Insects = insects;
            CollectedInsects = collectedInsects;
            SetDataAsDirty();
        }

        public void SetCollectedInsect(List<InsectData> insect)
        {
            CollectedInsects = insect;
            SetDataAsDirty();
        }

        public void SetTotalCoin(int totalCoin)
        {
            TotalCoin = totalCoin;
            SetDataAsDirty();
        }

        public void AddShopItem(ShopItemController item)
        {
            _shopItemPool.Add(item);
        }

        public ShopItemController FindShopItem(string name)
        {
            ShopItemController shopItem = _shopItemPool.Find(item => string.Equals(name, item.Model.Name));
            return shopItem;
        }
    }
}
