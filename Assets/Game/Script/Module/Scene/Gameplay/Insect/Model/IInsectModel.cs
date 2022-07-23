using Agate.MVC.Base;

namespace FlappyInsect.Module.Insect
{
    public interface IInsectModel : IBaseModel
    {
        public string Name { get; }
    }
}
