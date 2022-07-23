using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.ConfigData;

namespace FlappyInsect.Module.GameAudio
{
    public class GameAudioController : BaseController<GameAudioController>
    {
        private ConfigDataController _configData;
        private AudioSource _bgm;
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            CreateBgmObject();
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _bgm.mute = !_configData.Model.IsBgmOn;
        }

        public void OnUpdateBgmConfig(UpdateBgmConfigMessage message)
        {
            _bgm.mute = !message.IsBgmOn;
        }

        private void CreateBgmObject()
        {
            GameObject bgmPrefabs = Resources.Load<GameObject>(@"Prefabs/BGM/BGM");
            GameObject bgmObject = GameObject.Instantiate(bgmPrefabs);
            GameObject.DontDestroyOnLoad(bgmObject);
            _bgm = bgmObject.GetComponent<AudioSource>();
        }
    }
}
