using Agate.MVC.Base;

namespace FlappyInsect.Module.GameplayAudio
{
    public class GameplayAudioModel : BaseModel, IGameplayAudioModel
    {
        public bool IsMuted { get; private set; }

        public void SetIsMuted(bool isMuted)
        {
            IsMuted = isMuted;
            SetDataAsDirty();
        }
    }
}
