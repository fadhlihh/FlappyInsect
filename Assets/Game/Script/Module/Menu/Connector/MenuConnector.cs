using UnityEngine;

using Game.Base.MVC;

using Game.Module.HighScore;

namespace Game.Module.Menu
{
    public class MenuConnector : GameConnector
    {
        private MenuController _menu;

        protected override void Connect()
        {
            Subscribe<UpdateHighScoreMessage>(_menu.OnUpdateHighScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateHighScoreMessage>(_menu.OnUpdateHighScore);
        }
    }
}
