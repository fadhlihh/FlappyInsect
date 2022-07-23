using System.Collections;
using UnityEngine;
using Agate.MVC.Base;

namespace FlappyInsect.Module.InsectsData
{
    public class InsectsDataController : DataController<InsectsDataController, InsectsDataModel, IInsectsDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Load();
        }

        private void Load()
        {
            TextAsset dataSource = Resources.Load<TextAsset>(@"Data/Insect/Insects");
            InsectCollection insectData = JsonUtility.FromJson<InsectCollection>(dataSource.text);
            _model.SetInsectData(insectData);
        }
    }
}
