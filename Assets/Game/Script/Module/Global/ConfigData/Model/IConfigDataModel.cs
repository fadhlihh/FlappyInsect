using Agate.MVC.Base;

namespace FlappyInsect.Module.ConfigData
{
    public interface IConfigDataModel : IBaseModel
    {
        public bool IsBgmOn { get; }
        public bool IsSfxOn { get; }
    }
}
