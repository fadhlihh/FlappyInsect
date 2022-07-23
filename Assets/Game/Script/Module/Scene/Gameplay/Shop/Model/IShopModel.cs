using System.Collections.Generic;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.Shop
{
    public interface IShopModel : IBaseModel
    {
        public int TotalCoin { get; }
        public List<InsectData> CollectedInsects { get; }
        public List<InsectData> Insects { get; }
    }
}
