using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectSelectionItem
{
    public class InsectSelectionItemModel : BaseModel, IInsectSelectionItemModel
    {
        public string Name { get; private set; }
        public bool IsSelected { get; private set; }
        public bool IsUnlocked { get; private set; }

        public InsectSelectionItemModel() { }
        public InsectSelectionItemModel(string name, bool isSelected, bool isUnlocked)
        {
            Name = name;
            IsSelected = isSelected;
            IsUnlocked = isUnlocked;
            SetDataAsDirty();
        }

        public void SetModelData(string name, bool isSelected, bool isUnlocked)
        {
            Name = name;
            IsSelected = isSelected;
            IsUnlocked = isUnlocked;
            SetDataAsDirty();
        }

        public void SetIsSelected(bool isSelected)
        {
            IsSelected = isSelected;
            SetDataAsDirty();
        }
    }
}
