using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

using Game.Base.MVC;

namespace Game.Module.GameOver
{
    public class GameOverView : GameObjectView<IGameOverModel>
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

        public void SetCallbacks(UnityAction onRestart, UnityAction onToMainMenu)
        {
            _restartButton.onClick.RemoveAllListeners();
            _restartButton.onClick.AddListener(onRestart);
            _mainMenuButton.onClick.RemoveAllListeners();
            _mainMenuButton.onClick.AddListener(onToMainMenu);
        }

        public void ShowGameOverPopUp()
        {
            _gameOverPopUp.SetActive(true);
        }

        protected override void InitRenderModel(IGameOverModel model)
        {
            _scoreText.text = $"Your Score: {model.Score}";
            _highScoreText.text = $"High Score: {model.HighScore}";
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            _scoreText.text = $"Your Score: {model.Score}";
            _highScoreText.text = $"High Score: {model.HighScore}";
        }
    }
}
