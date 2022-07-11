using UnityEngine;
using FlappyBird.Base.MVC;
using FlappyBird.Module.Input;
using FlappyBird.Module.Bird;

namespace FlappyBird.Module.GameplayAudio
{
    public class GameplayAudioController : GameBaseController<GameplayAudioController>
    {
        private AudioSource _birdWingsSFX;
        private AudioSource _addScoreSFX;
        private AudioSource _birdHitSFX;
        private AudioSource _gameOverSFX;

        public void OnMoveBird(MoveBirdMessage message)
        {
            _birdWingsSFX.Play();
        }
        public void OnAddScore(AddScoreMessage message)
        {
            _addScoreSFX.Play();
        }
        public void OnGameOver(GameOverMessage message)
        {
            _birdHitSFX.Play();
            _gameOverSFX.Play();
        }

        public void SetBirdWingsSFX(AudioSource birdWingsSFX)
        {
            _birdWingsSFX = birdWingsSFX;
        }

        public void SetAddScoreSFX(AudioSource addScoreSFX)
        {
            _addScoreSFX = addScoreSFX;
        }
        public void SetBirdHitSFX(AudioSource birdHitSFX)
        {
            _birdHitSFX = birdHitSFX;
        }
        public void SetGameOverSFX(AudioSource gameOverSFX)
        {
            _gameOverSFX = gameOverSFX;
        }
    }
}
