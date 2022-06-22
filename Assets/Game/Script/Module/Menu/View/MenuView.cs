using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using Game.Base.MVC;

namespace Game.Module.Menu
{
    public class MenuView : GameBaseView
    {
        [SerializeField]
        private Button _playButton;
        [SerializeField]
        private Button _exitGameButton;

        public void Init(UnityAction onPlay, UnityAction onExit)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onPlay);
            _exitGameButton.onClick.RemoveAllListeners();
            _exitGameButton.onClick.AddListener(onExit);
        }
    }
}
