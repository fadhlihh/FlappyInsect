using UnityEngine;
using UnityEngine.UI;

using Game.Base.MVC;

namespace Game.Module.PlayGame
{
    public class PlayGameView : GameObjectView<IPlayGameModel>
    {
        [SerializeField]
        private Image _playInstruction;

        protected override void InitRenderModel(IPlayGameModel model)
        {
            Debug.Log("Something change");
            _playInstruction.gameObject.SetActive(!model.IsPlaying);
        }

        protected override void UpdateRenderModel(IPlayGameModel model)
        {
            Debug.Log("Something change");
            _playInstruction.gameObject.SetActive(!model.IsPlaying);
        }
    }
}
