using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ConfigData
{
    public class ConfigDataController : DataController<ConfigDataController, ConfigDataModel, IConfigDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            Load();
        }

        public void SetBgm(UpdateBgmConfigMessage message)
        {
            _model.SetBgm(message.IsBgmOn);
            int bgmValue = message.IsBgmOn ? 1 : 0;
            PlayerPrefs.SetInt("IsBgmOn", bgmValue);
            PlayerPrefs.Save();
        }

        public void SetSfx(UpdateSfxConfigMessage message)
        {
            _model.SetSfx(message.IsSfxOn);
            int sfxValue = message.IsSfxOn ? 1 : 0;
            PlayerPrefs.SetInt("IsSfxOn", sfxValue);
            PlayerPrefs.Save();
        }

        private void Load()
        {
            int bgmValue = PlayerPrefs.GetInt("IsBgmOn");
            int sfxValue = PlayerPrefs.GetInt("IsSfxOn");
            bool isBgmOn = bgmValue == 1;
            bool isSfxOn = sfxValue == 1;
            _model.SetBgm(isBgmOn);
            _model.SetSfx(isSfxOn);
        }
    }
}
