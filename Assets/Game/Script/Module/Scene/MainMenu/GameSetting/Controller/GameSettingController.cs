using System.Collections;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.ConfigData;

namespace FlappyInsect.Module.GameSetting
{
    public class GameSettingController : ObjectController<GameSettingController, GameSettingModel, IGameSettingModel, GameSettingView>
    {
        private ConfigDataController _configData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            Load();
        }

        public override void SetView(GameSettingView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnBgmToggle, OnSfxToggle);
        }

        public void Load()
        {
            _model.SetBgm(_configData.Model.IsBgmOn);
            _model.SetSfx(_configData.Model.IsSfxOn);
        }

        public void OnShowSetting(ShowSettingMessage message)
        {
            _view.Show();
        }

        public void OnSfxToggle(bool value)
        {
            _model.SetSfx(value);
            Publish<UpdateSfxConfigMessage>(new UpdateSfxConfigMessage(value));
            _configData.SetSfx(value);
        }

        public void OnBgmToggle(bool value)
        {
            _model.SetBgm(value);
            Publish<UpdateBgmConfigMessage>(new UpdateBgmConfigMessage(value));
            _configData.SetBgm(value);
        }
    }
}
