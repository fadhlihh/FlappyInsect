using UnityEngine;
using FlappyBird.Base.MVC;
using FlappyBird.Module.PlayGame;
using FlappyBird.Module.PipeContainer;
using FlappyBird.Module.Bird;
using FlappyBird.Module.Score;
using FlappyBird.Module.GameOver;

namespace FlappyBird.Scene.Gameplay
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
