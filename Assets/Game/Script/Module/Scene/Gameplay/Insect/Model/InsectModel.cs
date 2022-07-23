using Agate.MVC.Base;

namespace FlappyInsect.Module.Insect
{
    public class InsectModel : BaseModel, IInsectModel
    {
        public float Force = 10000f;
        public float GravityScale { get; private set; } = 0.5f;
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
            SetDataAsDirty();
        }
    }
}
