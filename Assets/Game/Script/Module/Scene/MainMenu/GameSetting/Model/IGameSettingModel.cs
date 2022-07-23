using Agate.MVC.Base;

namespace FlappyInsect.Module.GameSetting
{
    public interface IGameSettingModel : IBaseModel
    {
        public bool IsSfxOn { get; }
        public bool IsBgmOn { get; }
    }
}
