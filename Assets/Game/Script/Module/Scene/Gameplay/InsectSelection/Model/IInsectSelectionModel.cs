using System.Collections.Generic;
using Agate.MVC.Base;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.InsectSelection
{
    public interface IInsectSelectionModel : IBaseModel
    {
        public List<InsectData> CollectedInsects { get; }
        public List<InsectData> Insects { get; }
        public InsectData SelectedInsect { get; }
    }
}
