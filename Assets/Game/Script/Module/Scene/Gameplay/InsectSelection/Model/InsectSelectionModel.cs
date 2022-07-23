using System.Collections.Generic;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.InsectSelection
{
    public class InsectSelectionModel : BaseModel, IInsectSelectionModel
    {
        public List<InsectData> CollectedInsects { get; private set; }
        public List<InsectData> Insects { get; private set; }
        public InsectData SelectedInsect { get; private set; }

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
    }
}
