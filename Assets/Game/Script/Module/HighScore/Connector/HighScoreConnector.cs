using Game.Base.MVC;
using Game.Module.Score;

namespace Game.Module.HighScore
{
    public class HighScoreConnector : GameConnector
    {
        HighScoreController _highScore;
        protected override void Connect()
        {
            Subscribe<UpdateScoreMessage>(_highScore.OnUpdateScore);
        }

        protected override void Disconnect()
        {
            Unsubscribe<UpdateScoreMessage>(_highScore.OnUpdateScore);
        }
    }
}
