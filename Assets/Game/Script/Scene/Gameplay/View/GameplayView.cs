using UnityEngine;

using Game.Base.MVC;
using Game.Module.PlayGame;
using Game.Module.PipeContainer;
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
        public PipeContainerView PipeContainerView;
        [SerializeField]
        public Rigidbody2D BirdPhysics;
        [SerializeField]
        public BirdCollisionView BirdCollisionView;
        [SerializeField]
        public ScoreView ScoreCounterView;
        [SerializeField]
        public GameOverView GameOverView;
        [SerializeField]
        public Camera MainCamera;
    }
}
