using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Input
{
    public class TapInputModel : GameBaseModel
    {
        public InputActionManager InputActionsManager { get; } = new InputActionManager();
    }
}
