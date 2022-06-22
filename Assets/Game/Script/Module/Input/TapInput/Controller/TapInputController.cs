using UnityEngine;

using Game.Base.MVC;
using System.Collections;
using UnityEngine.InputSystem;

namespace Game.Module.Input
{
    public class TapInputController : GameDataController<TapInputController, TapInputModel>
    {
        public override IEnumerator Initialize()
        {
            _model.InputActionsManager.UI.Enable();
            _model.InputActionsManager.UI.TapStart.performed += OnTapStart;
            _model.InputActionsManager.Character.Tap.performed += OnTap;
            return base.Initialize();
        }

        public void OnTapStart(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Debug.Log("Start");
                _model.InputActionsManager.Character.Enable();
                _model.InputActionsManager.UI.Disable();
                Publish<TapStartMessage>(new TapStartMessage());
            }
        }

        public void OnTap(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Debug.Log("Pop");
            }
        }
    }
}
