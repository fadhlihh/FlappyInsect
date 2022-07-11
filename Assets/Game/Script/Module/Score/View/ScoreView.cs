using UnityEngine;
using TMPro;
using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Score
{
    public class ScoreView : GameObjectView<IScoreModel>
    {
        [SerializeField]
        public TextMeshProUGUI ScoreText;
        protected override void InitRenderModel(IScoreModel model)
        {
            ScoreText.text = model.Score.ToString();
        }

        protected override void UpdateRenderModel(IScoreModel model)
        {
            ScoreText.text = model.Score.ToString();
        }
    }
}
