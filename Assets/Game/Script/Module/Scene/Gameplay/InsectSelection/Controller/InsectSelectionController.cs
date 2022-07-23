using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.InsectsData;
using FlappyInsect.Module.ProgressData;
using FlappyInsect.Module.InsectSelectionItem;

namespace FlappyInsect.Module.InsectSelection
{
    public class InsectSelectionController : ObjectController<InsectSelectionController, InsectSelectionModel, IInsectSelectionModel, InsectSelectionView>
    {
        private InsectsDataController _insectData;
        private ProgressDataController _progressData;
        private List<InsectSelectionItemController> _insectSelectionItemPool = new List<InsectSelectionItemController>();

        public override void SetView(InsectSelectionView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnShowInsectSelectionItem);
            _model.SetModelData(_insectData.Model.InsectData.Insects, _progressData.Model.Progress.Insects, _progressData.Model.Progress.SelectedInsect);
        }

        public void OnShowInsectSelection(ShowInsectSelectionMessage message)
        {
            _view.Show();
        }

        public void OnInsectChange(InsectChangeMessage message)
        {
            InsectData insect = _model.CollectedInsects.Find(item => string.Equals(item.Name, message.Name));
            _model.SetSelectedInsect(insect);
            _progressData.ChangeSelectedInsect(insect);
            _progressData.SaveProgress();
        }

        public void OnPurchaseInsect(PurchaseInsectMessage message)
        {
            _model.SetCollectedInsect(_progressData.Model.Progress.Insects);
        }

        public void OnShowInsectSelectionItem()
        {
            if (_insectSelectionItemPool.Count <= 0)
            {
                CreateInsectSelectionItem();
            }
            else
            {
                UpdateInsectSelectionItem();
            }
        }

        private void CreateInsectSelectionItem()
        {
            foreach (InsectData insect in _model.Insects)
            {
                bool isUnlocked = _model.CollectedInsects.Exists(item => string.Equals(item.Name, insect.Name));
                bool isSelected = string.Equals(insect.Name, _model.SelectedInsect.Name);
                InsectSelectionItemModel itemModel = new InsectSelectionItemModel(insect.Name, isSelected, isUnlocked);
                GameObject itemObject = _view.CreateItemObject(itemModel.Name);
                InsectSelectionItemView itemView = itemObject.GetComponent<InsectSelectionItemView>();
                InsectSelectionItemController insectSelectionItem = new InsectSelectionItemController();
                InjectDependencies(insectSelectionItem);
                insectSelectionItem.Init(itemModel, itemView);
                _insectSelectionItemPool.Add(insectSelectionItem);
            }
        }

        private void UpdateInsectSelectionItem()
        {
            foreach (InsectData insect in _model.Insects)
            {
                bool isUnlocked = _model.CollectedInsects.Exists(item => string.Equals(item.Name, insect.Name));
                bool isSelected = string.Equals(insect.Name, _model.SelectedInsect.Name);
                InsectSelectionItemController insectSelectionItem = _insectSelectionItemPool.Find(item => string.Equals(insect.Name, item.Model.Name));
                insectSelectionItem.UpdateModelData(insect.Name, isSelected, isUnlocked);
            }
        }
    }
}
