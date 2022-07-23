using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using Agate.MVC.Base;

namespace FlappyInsect.Module.GameOver
{
    public class GameOverView : ObjectView<IGameOverModel>
    {
        [SerializeField]
        private GameObject _gameOverPopUp;
        [SerializeField]
        private TextMeshProUGUI _scoreText;
        [SerializeField]
        private TextMeshProUGUI _highScoreText;
        [SerializeField]
        private TextMeshProUGUI _coinText;
        [SerializeField]
        private Button _restartButton;
        [SerializeField]
        private Button _mainMenuButton;
        [SerializeField]
        private Button _exitGameButton;

        public void SetCallbacks(UnityAction onRestart, UnityAction onToMainMenu, UnityAction onExitGame)
        {
            _restartButton.onClick.RemoveAllListeners();
            _mainMenuButton.onClick.RemoveAllListeners();
            _exitGameButton.onClick.RemoveAllListeners();
            _restartButton.onClick.AddListener(onRestart);
            _mainMenuButton.onClick.AddListener(onToMainMenu);
            _exitGameButton.onClick.AddListener(onExitGame);
        }

        public void Show()
        {
            _gameOverPopUp.SetActive(true);
        }

        protected override void InitRenderModel(IGameOverModel model)
        {
            _scoreText.text = model.Score.ToString();
            _highScoreText.text = model.HighScore.ToString();
            _coinText.text = model.Coin.ToString();
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            _scoreText.text = model.Score.ToString();
            _highScoreText.text = model.HighScore.ToString();
            _coinText.text = model.Coin.ToString();
        }
    }
}
