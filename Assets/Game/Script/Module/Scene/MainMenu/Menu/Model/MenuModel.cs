using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Menu
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