using UnityEngine;
using UnityEngine.SceneManagement;

using Game.Base.MVC;

using Game.Module.HighScore;
using Game.Utilty;
using System.Collections;

namespace Game.Module.Menu
{
    public class MenuController : GameObjectController<MenuController, MenuModel, IMenuModel, MenuView>
    {
        HighScoreCounterController _highScoreCounter;

        public override void SetView(MenuView view)
        {
            base.SetView(view);
            _model.SetHighScore(_highScoreCounter.Model.HighScore);
            view.SetCallbacks(OnPlay, OnExit);
        }

        public void OnUpdateHighScore(UpdateHighScoreMessage message)
        {
            _model.SetHighScore(message.HighScore);
        }

        public void OnPlay()
        {
            SceneManager.LoadScene(GameScene.GamePlay, LoadSceneMode.Additive);
        }

        public void OnExit()
        {
            Application.Quit();
        }
    }
}
