using Agate.MVC.Base;

namespace Game.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        /// There are bugs in loading screen
        // private GameObject _loadingScreen;
        // protected override void ShowLoadingView()
        // {
        //     _loadingScreen = Object.Instantiate(Resources.Load("Prefabs/Loading/LoadingScreen")) as GameObject;
        // }
        // protected override void HideLoadingView()
        // {
        //     if (_loadingScreen)
        //     {
        //         Object.Destroy(_loadingScreen);
        //     }
        // }
    }
}
