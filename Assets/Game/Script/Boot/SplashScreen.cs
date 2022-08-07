using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace FlappyInsect.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        [SerializeField]
        private Transform _splashText;
        [SerializeField]
        private Transform _loadingText;

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override void StartSplash()
        {
            base.StartSplash();
            _splashText.gameObject.SetActive(true);
        }

        protected override void FinishSplash()
        {
            base.FinishSplash();
            _splashText.gameObject.SetActive(false);
        }

        protected override void StartTransition()
        {
            base.StartTransition();
            _loadingText.gameObject.SetActive(true);
        }

        protected override void FinishTransition()
        {
            base.FinishTransition();
            _loadingText.gameObject.SetActive(false);
        }
    }
}
