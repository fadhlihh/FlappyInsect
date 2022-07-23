using Agate.MVC.Base;

namespace FlappyInsect.Module.ProgressData
{
    public interface IProgressDataModel : IBaseModel
    {
        public Progress Progress { get; }
    }
}
