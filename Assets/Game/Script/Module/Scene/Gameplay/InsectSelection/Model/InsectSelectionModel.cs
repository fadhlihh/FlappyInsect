using System.Collections.Generic;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;
using FlappyInsect.Module.InsectSelectionItem;

namespace FlappyInsect.Module.InsectSelection
{
    public class InsectSelectionModel : BaseModel, IInsectSelectionModel
    {
        private List<InsectSelectionItemController> _insectSelectionItemPool = new List<InsectSelectionItemController>();

        public List<InsectData> CollectedInsects { get; private set; }
        public List<InsectData> Insects { get; private set; }
        public InsectData SelectedInsect { get; private set; }
        public int InsectSelectionItemCount => _insectSelectionItemPool.Count;

        public void SetModelData(List<InsectData> insects, List<InsectData> collectedInsects, InsectData selectedInsect)
        {
            Insects = insects;
            CollectedInsects = collectedInsects;
            SelectedInsect = selectedInsect;
            SetDataAsDirty();
        }

        public void SetCollectedInsect(List<InsectData> insect)
        {
            CollectedInsects = insect;
            SetDataAsDirty();
        }

        public void SetSelectedInsect(InsectData selectedInsect)
        {
            SelectedInsect = selectedInsect;
            SetDataAsDirty();
        }

        public void AddSelectionItem(InsectSelectionItemController insectSelectionItem)
        {
            _insectSelectionItemPool.Add(insectSelectionItem);
        }

        public InsectSelectionItemController FindSelectionItem(string name)
        {
            InsectSelectionItemController insectSelectionItem = _insectSelectionItemPool.Find(item => string.Equals(name, item.Model.Name));
            return insectSelectionItem;
        }
    }
}
