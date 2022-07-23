using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectSelectionItem
{
    public class InsectSelectionItemView : ObjectView<IInsectSelectionItemModel>
    {
        [SerializeField]
        private Image _insectImage;

        public void SetCallbacks(UnityAction<bool> onToggleValueChange)
        {
            GetComponent<Toggle>().onValueChanged.RemoveAllListeners();
            GetComponent<Toggle>().onValueChanged.AddListener(onToggleValueChange);
        }

        protected override void InitRenderModel(IInsectSelectionItemModel model)
        {
            string spriteName = model.IsUnlocked ? model.Name : "InsectLocked";
            Sprite insectSprite = Resources.LoadAll<Sprite>($"Sprites/Insect/{spriteName}")[0];
            _insectImage.sprite = insectSprite;
            GetComponent<Toggle>().isOn = model.IsSelected;
            GetComponent<Toggle>().interactable = model.IsUnlocked;
        }

        protected override void UpdateRenderModel(IInsectSelectionItemModel model)
        {
            string spriteName = model.IsUnlocked ? model.Name : "InsectLocked";
            Sprite insectSprite = Resources.LoadAll<Sprite>($"Sprites/Insect/{spriteName}")[0];
            _insectImage.sprite = insectSprite;
            GetComponent<Toggle>().isOn = model.IsSelected;
            GetComponent<Toggle>().interactable = model.IsUnlocked;
        }
    }
}
