using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

using Game.Base.MVC;

namespace Game.Module.GameOver
{
    public class GameOverPopUpView : GameBaseView
    {
        [SerializeField]
        private GameObject _gameOverPopUp;
        [SerializeField]
        private TextMeshProUGUI _scoreText;
        [SerializeField]
        private TextMeshProUGUI _highScoreText;
        [SerializeField]
        private Button _restartButton;
        [SerializeField]
        private Button _mainMenuButton;

        public void Init(int score, int highScore, UnityAction onRestart, UnityAction onToMainMenu)
        {
            _gameOverPopUp.SetActive(true);
            _scoreText.text = $"Your Score: {score.ToString()}";
            _highScoreText.text = $"High Score: {highScore.ToString()}";
            _restartButton.onClick.RemoveAllListeners();
            _restartButton.onClick.AddListener(onRestart);
            _mainMenuButton.onClick.RemoveAllListeners();
            _mainMenuButton.onClick.AddListener(onToMainMenu);
        }
    }
}
