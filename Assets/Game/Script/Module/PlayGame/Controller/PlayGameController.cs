using UnityEngine;
using Game.Base.MVC;

using Game.Module.Input;

namespace Game.Module.PlayGame
{
    public class PlayGameController : GameObjectController<PlayGameController, PlayGameModel, IPlayGameModel, PlayGameView>
    {
        public void OnTapStart(TapStartMessage message)
        {
            _model.SetIsPlaying(true);
        }
    }
}
