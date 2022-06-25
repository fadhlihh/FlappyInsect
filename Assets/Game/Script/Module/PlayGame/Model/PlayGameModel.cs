using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.PlayGame
{
    public class PlayGameModel : GameBaseModel, IPlayGameModel
    {
        public bool IsPlaying { get; private set; } = false;
        public void SetIsPlaying(bool isPlaying)
        {
            IsPlaying = isPlaying;
            SetDataAsDirty();
        }
    }
}
