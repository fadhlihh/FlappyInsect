using System.Collections;
using UnityEngine.InputSystem;
using FlappyBird.Base.MVC;
using FlappyBird.Module.Bird;

namespace FlappyBird.Module.Input
{
    public class TapInputController : GameBaseController<TapInputController>
    {
        private InputActionManager _inputActionsManager = new InputActionManager();
        public override IEnumerator Initialize()
        {
            _inputActionsManager.UI.Enable();
            _inputActionsManager.UI.TapStart.performed += OnTapStart;
            _inputActionsManager.Character.Tap.performed += OnTap;
            return base.Initialize();
        }

        public void OnGameOver(GameOverMessage message)
        {
            _inputActionsManager.Character.Disable();
        }

        private void OnTapStart(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _inputActionsManager.Character.Enable();
                _inputActionsManager.UI.Disable();
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
