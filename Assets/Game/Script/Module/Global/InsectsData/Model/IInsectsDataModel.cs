using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectsData
{
    public interface IInsectsDataModel : IBaseModel
    {
        public InsectCollection InsectData { get; }
    }
}
