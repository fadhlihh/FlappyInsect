using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Boot;
using FlappyInsect.Utilty;
using FlappyInsect.Message;

namespace FlappyInsect.Module.GamePause
{
    public class GamePauseController : ObjectController<GamePauseController, GamePauseView>
    {
        public override void SetView(GamePauseView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnPlay, OnSetting, OnMainMenu, OnExit);
        }

        public void OnShowGamePause(ShowGamePauseMessage message)
        {
            _view.Show();
            Time.timeScale = 0;
        }

        private void OnPlay()
        {
            _view.Hide();
            Time.timeScale = 1;
        }

        private void OnSetting()
        {
            Publish<ShowSettingMessage>(new ShowSettingMessage());
        }

        private void OnMainMenu()
        {
            SceneLoader.Instance.LoadScene(GameScene.MainMenu);
        }

        private void OnExit()
        {
            Application.Quit();
        }
    }
}
