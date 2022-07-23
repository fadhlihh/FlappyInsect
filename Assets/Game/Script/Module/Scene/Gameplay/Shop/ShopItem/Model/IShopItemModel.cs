using Agate.MVC.Base;

namespace FlappyInsect.Module.ShopItem
{
    public interface IShopItemModel : IBaseModel
    {
        public string Name { get; }
        public int Cost { get; }
        public bool IsSold { get; }
        public bool IsCostAffordable { get; }
    }
}
