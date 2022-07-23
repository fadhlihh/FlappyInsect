using Agate.MVC.Base;

namespace FlappyInsect.Module.ShopItem
{
    public class ShopItemModel : BaseModel, IShopItemModel
    {
        public string Name { get; private set; }
        public int Cost { get; private set; }
        public bool IsSold { get; private set; }
        public bool IsCostAffordable { get; private set; }

        public ShopItemModel() { }

        public ShopItemModel(string name, int cost, bool isSold, bool isCostAffordable)
        {
            Name = name;
            Cost = cost;
            IsSold = isSold;
            IsCostAffordable = isCostAffordable;
            SetDataAsDirty();
        }

        public void SetModelData(string name, int cost, bool isSold, bool isCostAffordable)
        {
            Name = name;
            Cost = cost;
            IsSold = isSold;
            IsCostAffordable = isCostAffordable;
            SetDataAsDirty();
        }
    }
}
