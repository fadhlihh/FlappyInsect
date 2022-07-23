using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace FlappyInsect.Module.Shop
{
    public class ShopView : ObjectView<IShopModel>
    {
        [SerializeField]
        private Transform _shopPopUp;
        [SerializeField]
        private Button _backButton;
        [SerializeField]
        private TextMeshProUGUI _totalCoinText;
        [SerializeField]
        private Transform _itemContainer;
        [SerializeField]
        private GameObject _itemPrefabs;

        private UnityAction _onShowShopItem;

        public GameObject CreateItemObject(string name)
        {
            GameObject itemObject = GameObject.Instantiate(_itemPrefabs, _itemContainer);
            itemObject.name = name;
            itemObject.SetActive(true);
            return itemObject;
        }

        public void SetCallbacks(UnityAction onShowShopItem)
        {
            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(OnBack);
            _onShowShopItem = onShowShopItem;
        }

        public void Show()
        {
            _shopPopUp.gameObject.SetActive(true);
        }

        protected override void InitRenderModel(IShopModel model)
        {

        }

        protected override void UpdateRenderModel(IShopModel model)
        {
            _totalCoinText.text = $"Coin: {model.TotalCoin.ToString()}";
            _onShowShopItem?.Invoke();
        }

        private void OnBack()
        {
            _shopPopUp.gameObject.SetActive(false);
        }
    }
}
