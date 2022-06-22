using Agate.MVC.Base;
using Agate.MVC.Core;

namespace Game.Boot
{
    public abstract class SceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
    where TLauncher : SceneLauncher<TLauncher, TView>
    where TView : BaseSceneView
    {
        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameLauncher.Instance;
        }
    }
}
