using System.Collections;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.ConfigData;

namespace FlappyInsect.Module.GameplayAudio
{
    public class GameplayAudioController : ObjectController<GameplayAudioController, GameplayAudioModel, IGameplayAudioModel, GameplayAudioView>
    {
        private ConfigDataController _configData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetIsMuted(!_configData.Model.IsSfxOn);
        }

        public void OnUpdateSfxConfig(UpdateSfxConfigMessage message)
        {
            _model.SetIsMuted(!message.IsSfxOn);
        }

        public void OnMoveInsect(MoveInsectMessage message)
        {
            _view.PlayBirdWingsSfx();
        }

        public void OnAddScore(AddScoreMessage message)
        {
            _view.PlayAddScoreSfx();
        }

        public void OnAddCoin(AddCoinMessage message)
        {
            _view.PlayAddCoinSfx();
        }

        public void OnGameOver(GameOverMessage message)
        {
            _view.PlayGameOverSfx();
        }
    }
}
