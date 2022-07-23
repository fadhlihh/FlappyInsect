using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectSelectionItem
{
    public interface IInsectSelectionItemModel : IBaseModel
    {
        public string Name { get; }
        public bool IsSelected { get; }
        public bool IsUnlocked { get; }
    }
}
