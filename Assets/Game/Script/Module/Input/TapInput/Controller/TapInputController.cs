using System.Collections;
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

        public void OnGameOver(GameOverMessage message)
        {
            InputActionsManager.Character.Disable();
        }

        private void OnTapStart(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                InputActionsManager.Character.Enable();
                InputActionsManager.UI.Disable();
                Publish<StartPlayMessage>(new StartPlayMessage());
            }
        }

        private void OnTap(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Publish<MoveBirdMessage>(new MoveBirdMessage());
            }
        }
    }
}
