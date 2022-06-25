using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.Input
{
    public class TapInputController : GameBaseController<TapInputController>
    {
        private InputActionManager InputActionsManager = new InputActionManager();
        public override IEnumerator Initialize()
        {
            InputActionsManager.UI.Enable();
            InputActionsManager.UI.TapStart.performed += OnTapStart;
            InputActionsManager.Character.Tap.performed += OnTap;
            return base.Initialize();
        }

        public void OnTapStart(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                InputActionsManager.Character.Enable();
                InputActionsManager.UI.Disable();
                Publish<TapStartMessage>(new TapStartMessage());
            }
        }

        public void OnTap(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Publish<TapMessage>(new TapMessage());
            }
        }

        public void OnGameOver(BirdDeathMessage message)
        {
            InputActionsManager.Character.Disable();
        }
    }
}
