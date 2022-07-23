using Agate.MVC.Base;

namespace FlappyInsect.Module.GameSetting
{
    public class GameSettingModel : BaseModel, IGameSettingModel
    {
        public bool IsSfxOn { get; private set; }
        public bool IsBgmOn { get; private set; }

        public void SetSfx(bool isSfxOn)
        {
            IsSfxOn = isSfxOn;
            SetDataAsDirty();
        }
        public void SetBgm(bool isBgmOn)
        {
            IsBgmOn = isBgmOn;
            SetDataAsDirty();
        }
    }
}
