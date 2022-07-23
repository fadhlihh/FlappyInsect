using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Module.Menu;
using FlappyInsect.Module.GameSetting;

namespace FlappyInsect.Scene.MainMenu
{
    public class MainMenuView : BaseSceneView
    {
        [SerializeField]
        public MenuView MenuView;
        [SerializeField]
        public GameSettingView GameSettingView;
    }
}
