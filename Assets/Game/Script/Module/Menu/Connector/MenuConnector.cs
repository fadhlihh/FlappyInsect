using FlappyBird.Base.MVC;
using FlappyBird.Module.HighScoreData;

namespace FlappyBird.Module.Menu
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
