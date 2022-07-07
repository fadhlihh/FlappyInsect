using UnityEngine;
using UnityEngine.UI;
using Game.Base.MVC;

namespace Game.Module.PlayGame
{
    public class PlayGameView : GameObjectView<IPlayGameModel>
    {
        [SerializeField]
        private Image _tapToStartPopUp;

        protected override void InitRenderModel(IPlayGameModel model)
        {
            _tapToStartPopUp.gameObject.SetActive(!model.IsPlaying);
        }

        protected override void UpdateRenderModel(IPlayGameModel model)
        {
            _tapToStartPopUp.gameObject.SetActive(!model.IsPlaying);
        }
    }
}
