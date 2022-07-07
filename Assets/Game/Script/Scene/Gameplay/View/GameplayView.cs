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
        [Header("Camera")]
        [SerializeField]
        public Camera MainCamera;
        [Header("View")]
        [SerializeField]
        public PlayGameView PlayGameView;
        [SerializeField]
        public PipeContainerView PipeContainerView;
        [SerializeField]
        public BirdCollisionView BirdCollisionView;
        [SerializeField]
        public ScoreView ScoreCounterView;
        [SerializeField]
        public GameOverView GameOverView;
        [SerializeField]
        public Rigidbody2D BirdPhysics;
        [Header("Audio")]
        [SerializeField]
        public AudioSource BirdWingsSFX;
        [SerializeField]
        public AudioSource AddScoreSFX;
        [SerializeField]
        public AudioSource BirdHitSFX;
        [SerializeField]
        public AudioSource GameOverSFX;
    }
}
