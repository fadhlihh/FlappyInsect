using UnityEngine;

using Game.Base.MVC;
using Game.Module.PlayGame;

namespace Game.Scene.Gameplay
{
    public class GameplayView : GameBaseSceneView
    {
        [SerializeField]
        public PlayGameView PlayGameView;
    }
}
