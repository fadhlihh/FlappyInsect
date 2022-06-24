using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.Input
{
    public class TapInputConnector : GameConnector
    {
        private TapInputController _tapInput;
        protected override void Connect()
        {
            Subscribe<BirdDeathMessage>(_tapInput.OnGameOver);
        }

        protected override void Disconnect()
        {
            Subscribe<BirdDeathMessage>(_tapInput.OnGameOver);
        }
    }
}
