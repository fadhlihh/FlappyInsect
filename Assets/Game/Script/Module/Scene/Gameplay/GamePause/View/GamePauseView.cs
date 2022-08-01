using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.UI;
using UnityEngine.Events;

namespace FlappyInsect.Module.GamePause
{
    public class GamePauseView : BaseView
    {
        [SerializeField]
        private Transform _gamePausePopUp;
        [SerializeField]
        private Button _playButton;
        [SerializeField]
        private Button _settingButton;
        [SerializeField]
        private Button _mainMenuButton;
        [SerializeField]
        private Button _exitGameButton;

        public void Show()
        {
            _gamePausePopUp.gameObject.SetActive(true);
        }

        public void SetCallbacks(UnityAction onPlay, UnityAction onSetting, UnityAction onMainMenu, UnityAction onExit)
        {
            _playButton.onClick.RemoveAllListeners();
            _settingButton.onClick.RemoveAllListeners();
            _mainMenuButton.onClick.RemoveAllListeners();
            _exitGameButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onPlay);
            _settingButton.onClick.AddListener(onSetting);
            _mainMenuButton.onClick.AddListener(onMainMenu);
            _exitGameButton.onClick.AddListener(onExit);
        }

        public void Hide()
        {
            _gamePausePopUp.gameObject.SetActive(false);
        }
    }
}
