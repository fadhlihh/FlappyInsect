using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.Score
{
    public class AddScoreAudiConnector : GameConnector
    {
        private AddScoreAudioController _addScoreAudio;

        protected override void Connect()
        {
            Subscribe<BirdAddScoreMessage>(_addScoreAudio.OnAddScore);
        }

        protected override void Disconnect()
        {
            Subscribe<BirdAddScoreMessage>(_addScoreAudio.OnAddScore);
        }
    }
}
