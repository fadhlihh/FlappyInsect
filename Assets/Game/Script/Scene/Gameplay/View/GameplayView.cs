using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Module.HUD;
using FlappyInsect.Module.Shop;
using FlappyInsect.Module.InsectSelection;
using FlappyInsect.Module.GameSetting;
using FlappyInsect.Module.GamePause;
using FlappyInsect.Module.ObstaclePool;
using FlappyInsect.Module.Insect;
using FlappyInsect.Module.CoinPool;
using FlappyInsect.Module.GameOver;
using FlappyInsect.Module.GameplayAudio;

namespace FlappyInsect.Scene.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public HUDView HUDView;
        [SerializeField]
        public InsectSelectionView InsectSelectionView;
        [SerializeField]
        public ShopView ShopView;
        [SerializeField]
        public GameSettingView GameSettingView;
        [SerializeField]
        public GamePauseView GamePauseView;
        [SerializeField]
        public ObstaclePoolView ObstaclePoolView;
        [SerializeField]
        public InsectView InsectView;
        [SerializeField]
        public CoinPoolView CoinPoolView;
        [SerializeField]
        public GameOverView GameOverView;
        [SerializeField]
        public GameplayAudioView GameplayAudioView;
    }
}
