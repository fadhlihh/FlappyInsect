using UnityEngine;

using Game.Base.MVC;

namespace Game.Module.Menu
{
    public class MenuModel : GameBaseModel, IMenuModel
    {
        public int HighScore { get; private set; } = 0;

        public void SetHighScore(int highScore)
        {
            HighScore = highScore;
            SetDataAsDirty();
        }
    }
}
