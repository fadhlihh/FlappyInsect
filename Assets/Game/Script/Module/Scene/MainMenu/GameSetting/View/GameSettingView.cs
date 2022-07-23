using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Agate.MVC.Base;

namespace FlappyInsect.Module.GameSetting
{
    public class GameSettingView : ObjectView<IGameSettingModel>
    {
        [SerializeField]
        private Transform _gameSettingPopUp;
        [SerializeField]
        private Button _backButton;
        [SerializeField]
        private Toggle _bgmToggle;
        [SerializeField]
        private Toggle _sfxToggle;

        public void SetCallbacks(UnityAction<bool> onBgmToggle, UnityAction<bool> onSfxToggle)
        {
            _backButton.onClick.RemoveAllListeners();
            _bgmToggle.onValueChanged.RemoveAllListeners();
            _sfxToggle.onValueChanged.RemoveAllListeners();
            _backButton.onClick.AddListener(OnBack);
            _bgmToggle.onValueChanged.AddListener(onBgmToggle);
            _sfxToggle.onValueChanged.AddListener(onSfxToggle);
        }

        public void Show()
        {
            _gameSettingPopUp.gameObject.SetActive(true);
        }

        protected override void InitRenderModel(IGameSettingModel model)
        {
            _bgmToggle.isOn = model.IsBgmOn;
            _sfxToggle.isOn = model.IsSfxOn;
        }

        protected override void UpdateRenderModel(IGameSettingModel model)
        {
            _bgmToggle.isOn = model.IsBgmOn;
            _sfxToggle.isOn = model.IsSfxOn;
        }

        private void OnBack()
        {
            _gameSettingPopUp.gameObject.SetActive(false);
        }
    }
}
