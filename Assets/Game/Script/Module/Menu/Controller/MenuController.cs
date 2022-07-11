using System.Collections;
using UnityEngine;
using FlappyBird.Base.MVC;
using FlappyBird.Boot;
using FlappyBird.Module.HighScoreData;
using FlappyBird.Utilty;

namespace FlappyBird.Module.Menu
{
    public class MenuController : GameObjectController<MenuController, MenuModel, IMenuModel, MenuView>
    {
        private HighScoreDataController _highScore;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetHighScore(_highScore.Model.HighScore);
        }

        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnPlay, OnExit);
        }

        public void OnUpdateHighScore(UpdateHighScoreMessage message)
        {
            _model.SetHighScore(message.HighScore);
        }

        private void OnPlay()
        {
            SceneLoader.Instance.LoadScene(GameScene.GamePlay);
        }

        private void OnExit()
        {
            Application.Quit();
        }
    }
}
