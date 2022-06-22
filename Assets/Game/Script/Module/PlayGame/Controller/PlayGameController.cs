using UnityEngine;
using Game.Base.MVC;

using Game.Module.Input;

namespace Game.Module.PlayGame
{
    public class PlayGameController : GameObjectController<PlayGameController, PlayGameView>
    {
        public void OnDisablePlayGameView(TapStartMessage message)
        {
            _view.Image.gameObject.SetActive(false);
        }
    }
}
