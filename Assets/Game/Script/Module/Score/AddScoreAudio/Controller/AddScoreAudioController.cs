using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.Score
{
    public class AddScoreAudioController : GameBaseController<AddScoreAudioController>
    {
        public void OnAddScore(BirdAddScoreMessage message)
        {
            Debug.Log("Add Score Audio Play");
        }
    }
}
