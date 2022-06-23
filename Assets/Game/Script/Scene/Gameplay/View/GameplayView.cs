using UnityEngine;

using Game.Base.MVC;
using Game.Module.PlayGame;
using Game.Module.Pipe;
using Game.Module.Bird;

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
        [SerializeField]
        public BirdMovementView BirdMovementView;
        [SerializeField]
        public BirdAddScoreView BirdAddScoreView;
        [SerializeField]
        public BirdDeathView BirdDeathView;
    }
}
