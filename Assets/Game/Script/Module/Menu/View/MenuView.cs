using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

using Game.Base.MVC;

namespace Game.Module.Menu
{
    public class MenuView : GameObjectView<IMenuModel>
    {
        [SerializeField]
        private Button _playButton;
        [SerializeField]
        private Button _exitGameButton;
        [SerializeField]
        private TextMeshProUGUI _highScoreText;

        public void SetCallbacks(UnityAction onPlay, UnityAction onExit)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onPlay);
            _exitGameButton.onClick.RemoveAllListeners();
            _exitGameButton.onClick.AddListener(onExit);
        }

        protected override void InitRenderModel(IMenuModel model)
        {
            _highScoreText.text = $"High Score: {model.HighScore}";
        }

        protected override void UpdateRenderModel(IMenuModel model)
        {
            _highScoreText.text = $"High Score: {model.HighScore}";
        }
    }
}
