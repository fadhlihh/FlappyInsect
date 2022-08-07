using Agate.MVC.Base;
using FlappyInsect.Utilty;

namespace FlappyInsect.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene => GameScene.SplashScreen;
    }
}
