using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.InsectSelectionItem
{
    public class InsectSelectionItemController : ObjectController<InsectSelectionItemController, InsectSelectionItemModel, IInsectSelectionItemModel, InsectSelectionItemView>
    {
        public override void SetView(InsectSelectionItemView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnToggleValueChange);
        }

        public void Init(InsectSelectionItemModel model, InsectSelectionItemView view)
        {
            _model = model;
            SetView(view);
        }

        public void UpdateModelData(string name, bool isSelected, bool isUnlocked)
        {
            _model.SetModelData(name, isSelected, isUnlocked);
        }

        public void OnToggleValueChange(bool value)
        {
            _model.SetIsSelected(value);
            if (value)
            {
                Publish<InsectChangeMessage>(new InsectChangeMessage(_model.Name));
            }
        }
    }
}
