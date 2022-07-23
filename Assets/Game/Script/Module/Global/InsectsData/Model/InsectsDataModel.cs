using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectsData
{
    public class InsectsDataModel : BaseModel, IInsectsDataModel
    {
        public InsectCollection InsectData { get; private set; }
        public void SetInsectData(InsectCollection insectData)
        {
            InsectData = insectData;
            SetDataAsDirty();
        }
    }
}
