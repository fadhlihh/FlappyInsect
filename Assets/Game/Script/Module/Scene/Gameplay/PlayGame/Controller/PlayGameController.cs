using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;

namespace FlappyBird.Module.PlayGame
{
    public class PlayGameController : GameObjectController<PlayGameController, PlayGameModel, IPlayGameModel, PlayGameView>
    {
        public void OnStartPlay(StartPlayMessage message)
        {
            _model.SetIsPlaying(true);
        }
    }
}
