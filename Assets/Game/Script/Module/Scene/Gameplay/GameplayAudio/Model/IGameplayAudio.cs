using Agate.MVC.Base;

namespace FlappyInsect.Module.GameplayAudio
{
    public interface IGameplayAudioModel : IBaseModel
    {
        public bool IsMuted { get; }
    }
}
