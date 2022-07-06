using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.Audio
{
    public class GameplayAudioController : GameBaseController<GameplayAudioController>
    {
        public void OnAddScore(AddScoreMessage message)
        {
            Debug.Log("Play Add Score Audio");
        }
        public void OnGameOver(GameOverMessage message)
        {
            Debug.Log("Play Game Over Audio");
        }

    }
}
