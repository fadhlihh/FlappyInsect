using UnityEngine;

using Agate.MVC.Base;

namespace Game.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        /// There are bugs in loading screen
        // private GameObject _loadingScreen;
        // protected override void ShowLoadingView()
        // {
        //     Debug.Log("Show Loading");
        //     _loadingScreen = Object.Instantiate(Resources.Load("Prefabs/Loading/LoadingScreen")) as GameObject;
        // }
        // protected override void HideLoadingView()
        // {
        //     Debug.Log("Hide Loading");
        //     Object.Destroy(_loadingScreen);
        // }
    }
}
