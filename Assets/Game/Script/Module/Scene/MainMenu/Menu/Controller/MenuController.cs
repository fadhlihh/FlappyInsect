using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Boot;
using FlappyInsect.Message;
using FlappyInsect.Utilty;

namespace FlappyInsect.Module.Menu
{
    public class MenuController : ObjectController<MenuController, MenuView>
    {
        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnPlay, OnSetting, OnExit);
        }

        private void OnPlay()
        {
            SceneLoader.Instance.LoadScene(GameScene.GamePlay);
        }

        private void OnSetting()
        {
            Publish<ShowSettingMessage>(new ShowSettingMessage());
        }

        private void OnExit()
        {
            Application.Quit();
        }
    }
}
