using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using Agate.MVC.Base;

namespace FlappyInsect.Module.HUD
{
    public class HUDView : ObjectView<IHUDModel>
    {
        [SerializeField]
        private Transform _prePlayHUD;
        [SerializeField]
        private Transform _playingHUD;
        [SerializeField]
        private TextMeshProUGUI _highScoreText;
        [SerializeField]
        private TextMeshProUGUI _totalCoinText;
        [SerializeField]
        private TextMeshProUGUI _scoreText;
        [SerializeField]
        private TextMeshProUGUI _coinText;
        [SerializeField]
        private Button _settingButton;
        [SerializeField]
        private Button _insectSelectionButton;
        [SerializeField]
        private Button _shopButton;
        [SerializeField]
        private Button _gamePauseButton;

        public void SetCallbacks(UnityAction onSetting, UnityAction onInsectSelection, UnityAction onShop, UnityAction onGamePause)
        {
            _settingButton.onClick.RemoveAllListeners();
            _insectSelectionButton.onClick.RemoveAllListeners();
            _shopButton.onClick.RemoveAllListeners();
            _gamePauseButton.onClick.RemoveAllListeners();
            _settingButton.onClick.AddListener(onSetting);
            _insectSelectionButton.onClick.AddListener(onInsectSelection);
            _shopButton.onClick.AddListener(onShop);
            _gamePauseButton.onClick.AddListener(onGamePause);
        }

        protected override void InitRenderModel(IHUDModel model)
        {
            _prePlayHUD.gameObject.SetActive(!model.IsPlaying);
            _playingHUD.gameObject.SetActive(model.IsPlaying);
            _highScoreText.text = $"High Score: {model.HighScore}";
            _totalCoinText.text = $"Coin: {model.TotalCoin}";
            _scoreText.text = $"Score: {model.Score}";
            _coinText.text = $"Coin: {model.Coin}";
        }

        protected override void UpdateRenderModel(IHUDModel model)
        {
            _prePlayHUD.gameObject.SetActive(!model.IsPlaying);
            _playingHUD.gameObject.SetActive(model.IsPlaying);
            _highScoreText.text = $"High Score: {model.HighScore}";
            _totalCoinText.text = $"Coin: {model.TotalCoin}";
            _scoreText.text = $"Score: {model.Score}";
            _coinText.text = $"Coin: {model.Coin}";
        }
    }
}
