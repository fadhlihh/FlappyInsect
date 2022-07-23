using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace FlappyInsect.Module.Menu
{
    public class MenuView : BaseView
    {
        [SerializeField]
        private Button _playButton;
        [SerializeField]
        private Button _settingButton;
        [SerializeField]
        private Button _exitGameButton;

        public void SetCallbacks(UnityAction onPlay, UnityAction onSetting, UnityAction onExit)
        {
            _playButton.onClick.RemoveAllListeners();
            _settingButton.onClick.RemoveAllListeners();
            _exitGameButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onPlay);
            _settingButton.onClick.AddListener(onSetting);
            _exitGameButton.onClick.AddListener(onExit);
        }
    }
}
