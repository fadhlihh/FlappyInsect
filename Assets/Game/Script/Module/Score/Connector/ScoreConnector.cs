using FlappyBird.Base.MVC;
using FlappyBird.Module.Bird;
using FlappyBird.Module.Input;

namespace FlappyBird.Module.Score
{
    public class ScoreConnector : GameConnector
    {
        private ScoreController _score;
        protected override void Connect()
        {
            Subscribe<AddScoreMessage>(_score.OnAddScore);
            Subscribe<StartPlayMessage>(_score.OnStartPlay);
            Subscribe<GameOverMessage>(_score.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<AddScoreMessage>(_score.OnAddScore);
            Unsubscribe<StartPlayMessage>(_score.OnStartPlay);
            Unsubscribe<GameOverMessage>(_score.OnGameOver);
        }
    }
}
