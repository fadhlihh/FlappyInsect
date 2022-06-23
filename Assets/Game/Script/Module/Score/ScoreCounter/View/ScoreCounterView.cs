using UnityEngine;
using TMPro;

using Game.Base.MVC;

namespace Game.Module.Score
{
    public class ScoreCounterView : GameObjectView<IScoreCounterModel>
    {
        [SerializeField]
        public TextMeshProUGUI ScoreText;
        protected override void InitRenderModel(IScoreCounterModel model)
        {
            ScoreText.text = model.Score.ToString();
        }

        protected override void UpdateRenderModel(IScoreCounterModel model)
        {
            ScoreText.text = model.Score.ToString();
        }
    }
}
