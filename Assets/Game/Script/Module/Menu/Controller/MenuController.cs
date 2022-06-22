using UnityEngine;
using UnityEngine.SceneManagement;

using Game.Base.MVC;
using Game.Boot;
using Game.Utilty;

namespace Game.Module.Menu
{
    public class MenuController : GameObjectController<MenuController, MenuView>
    {
        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.Init(OnPlay, OnExit);
        }

        public static void OnPlay()
        {
            SceneManager.LoadScene(GameScene.GamePlay, LoadSceneMode.Additive);
        }

        public void OnExit()
        {
            Application.Quit();
        }
    }
}
