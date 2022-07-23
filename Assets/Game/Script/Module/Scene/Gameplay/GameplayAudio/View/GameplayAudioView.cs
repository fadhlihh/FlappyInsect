using UnityEngine;
using Agate.MVC.Base;

namespace FlappyInsect.Module.GameplayAudio
{
    public class GameplayAudioView : ObjectView<IGameplayAudioModel>
    {
        [SerializeField]
        private AudioSource _birdWingsSfx;
        [SerializeField]
        private AudioSource _addScoreSfx;
        [SerializeField]
        private AudioSource _addCoinSfx;
        [SerializeField]
        private AudioSource _birdHitSfx;
        [SerializeField]
        private AudioSource _gameOverSfx;

        public void PlayBirdWingsSfx()
        {
            _birdWingsSfx.Play();
        }

        public void PlayAddScoreSfx()
        {
            _addScoreSfx.Play();
        }
        public void PlayAddCoinSfx()
        {
            _addCoinSfx.Play();
        }

        public void PlayGameOverSfx()
        {
            _birdHitSfx.Play();
            _gameOverSfx.Play();
        }

        protected override void InitRenderModel(IGameplayAudioModel model)
        {
            _birdWingsSfx.mute = model.IsMuted;
            _addScoreSfx.mute = model.IsMuted;
            _addCoinSfx.mute = model.IsMuted;
            _birdHitSfx.mute = model.IsMuted;
            _gameOverSfx.mute = model.IsMuted;
        }

        protected override void UpdateRenderModel(IGameplayAudioModel model)
        {
            _birdWingsSfx.mute = model.IsMuted;
            _addScoreSfx.mute = model.IsMuted;
            _addCoinSfx.mute = model.IsMuted;
            _birdHitSfx.mute = model.IsMuted;
            _gameOverSfx.mute = model.IsMuted;
        }
    }
}
