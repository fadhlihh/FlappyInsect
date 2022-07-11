using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;
using FlappyBird.Module.Bird;

namespace FlappyBird.Module.GameplayAudio
{
    public class GameplayAudioConnector : GameConnector
    {
        private GameplayAudioController _audio;

        protected override void Connect()
        {
            Subscribe<MoveBirdMessage>(_audio.OnMoveBird);
            Subscribe<AddScoreMessage>(_audio.OnAddScore);
            Subscribe<GameOverMessage>(_audio.OnGameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MoveBirdMessage>(_audio.OnMoveBird);
            Unsubscribe<AddScoreMessage>(_audio.OnAddScore);
            Unsubscribe<GameOverMessage>(_audio.OnGameOver);
        }
    }
}
