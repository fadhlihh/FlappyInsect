using Agate.MVC.Base;

namespace FlappyInsect.Module.ConfigData
{
    public class ConfigDataModel : BaseModel, IConfigDataModel
    {
        public bool IsBgmOn { get; private set; }
        public bool IsSfxOn { get; private set; }

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
