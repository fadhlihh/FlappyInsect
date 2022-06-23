using UnityEngine;

using Game.Base.MVC;
using Game.Module.PlayGame;
using Game.Module.Pipe;

namespace Game.Scene.Gameplay
{
    public class GameplayView : GameBaseSceneView
    {
        [SerializeField]
        public PlayGameView PlayGameView;
        [SerializeField]
        public PipeScrollView PipeScrollView;
        [SerializeField]
        public PipeDespawnView PipeDespawnView;
    }
}
