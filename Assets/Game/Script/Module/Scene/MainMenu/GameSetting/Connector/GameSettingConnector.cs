using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.GameSetting
{
    public class GameSettingConnector : BaseConnector
    {
        private GameSettingController _gameSetting;
        protected override void Connect()
        {
            Subscribe<ShowSettingMessage>(_gameSetting.OnShowSetting);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShowSettingMessage>(_gameSetting.OnShowSetting);
        }
    }
}
