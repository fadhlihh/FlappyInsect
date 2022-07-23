using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectSelection
{
    public class InsectSelectionView : ObjectView<IInsectSelectionModel>
    {
        [SerializeField]
        private Transform _insectSelectionPopUp;
        [SerializeField]
        private Button _backButton;
        [SerializeField]
        private Transform _itemContainer;
        [SerializeField]
        private GameObject _itemPrefabs;

        private UnityAction _onShowInsectSelectionItem;

        public GameObject CreateItemObject(string name)
        {
            GameObject itemObject = GameObject.Instantiate(_itemPrefabs, _itemContainer);
            itemObject.name = name;
            itemObject.GetComponent<Toggle>().group = _itemContainer.GetComponent<ToggleGroup>();
            itemObject.SetActive(true);
            return itemObject;
        }

        public void SetCallbacks(UnityAction onShowInsectSelectionItem)
        {
            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(OnBack);
            _onShowInsectSelectionItem = onShowInsectSelectionItem;
        }

        public void Show()
        {
            _insectSelectionPopUp.gameObject.SetActive(true);
        }

        protected override void InitRenderModel(IInsectSelectionModel model)
        {

        }

        protected override void UpdateRenderModel(IInsectSelectionModel model)
        {
            _onShowInsectSelectionItem?.Invoke();
        }

        private void OnBack()
        {
            _insectSelectionPopUp.gameObject.SetActive(false);
        }
    }
}
