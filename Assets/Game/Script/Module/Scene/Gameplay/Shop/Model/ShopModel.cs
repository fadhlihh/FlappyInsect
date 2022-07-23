using System.Collections.Generic;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.Shop
{
    public class ShopModel : BaseModel, IShopModel
    {
        public int TotalCoin { get; private set; }
        public List<InsectData> CollectedInsects { get; private set; }
        public List<InsectData> Insects { get; private set; }

        public void SetModelData(int totalCoin, List<InsectData> insects, List<InsectData> collectedInsects)
        {
            TotalCoin = totalCoin;
            Insects = insects;
            CollectedInsects = collectedInsects;
            SetDataAsDirty();
        }

        public void AddCollectedInsect(InsectData insect)
        {
            CollectedInsects.Add(insect);
            SetDataAsDirty();
        }

        public void SetTotalCoin(int totalCoin)
        {
            TotalCoin = totalCoin;
            SetDataAsDirty();
        }
    }
}
