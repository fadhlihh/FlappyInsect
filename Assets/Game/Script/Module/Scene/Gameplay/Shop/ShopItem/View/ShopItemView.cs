using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace FlappyInsect.Module.ShopItem
{
    public class ShopItemView : ObjectView<IShopItemModel>
    {
        [SerializeField]
        private Image _insectImage;
        [SerializeField]
        private TextMeshProUGUI _costText;
        [SerializeField]
        private TextMeshProUGUI _soldText;
        [SerializeField]
        private Button _purchaseButton;

        public void SetCallbacks(UnityAction onPurchase)
        {
            _purchaseButton.onClick.RemoveAllListeners();
            _purchaseButton.onClick.AddListener(onPurchase);
        }

        protected override void InitRenderModel(IShopItemModel model)
        {
            Sprite insectSprite = Resources.LoadAll<Sprite>($"Sprites/Insect/{model.Name}")[0];
            _insectImage.sprite = insectSprite;
            string costText = (model.Cost > 0) ? model.Cost.ToString() : "FREE";
            _costText.text = costText;
            _soldText.gameObject.SetActive(model.IsSold);
            _purchaseButton.gameObject.SetActive(!model.IsSold);
            _purchaseButton.interactable = model.IsCostAffordable;
        }

        protected override void UpdateRenderModel(IShopItemModel model)
        {
            Sprite insectSprite = Resources.LoadAll<Sprite>($"Sprites/Insect/{model.Name}")[0];
            _insectImage.sprite = insectSprite;
            _soldText.gameObject.SetActive(model.IsSold);
            _purchaseButton.gameObject.SetActive(!model.IsSold);
            _purchaseButton.interactable = model.IsCostAffordable;
        }
    }
}
