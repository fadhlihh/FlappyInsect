using UnityEngine;

using Game.Base.MVC;
using Game.Module.PlayGame;
using Game.Module.Pipe;
using Game.Module.Bird;
using Game.Module.Score;
using Game.Module.GameOver;

namespace Game.Scene.Gameplay
{
    public class GameplayView : GameBaseSceneView
    {
        [SerializeField]
        public PlayGameView PlayGameView;
        [SerializeField]
        public PipeSpawnView PipeSpawnView;
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
        [SerializeField]
        public ScoreCounterView ScoreCounterView;
        [SerializeField]
        public GameOverPopUpView GameOverPopUpView;
    }
}
