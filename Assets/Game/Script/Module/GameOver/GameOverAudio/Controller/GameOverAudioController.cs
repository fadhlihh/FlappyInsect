using UnityEngine;

using Game.Base.MVC;
using Game.Module.Bird;

namespace Game.Module.GameOver
{
    public class GameOverAudioController : GameBaseController<GameOverAudioController>
    {
        public void OnGameOver(BirdDeathMessage message)
        {
            Debug.Log("Play Gameover Audio");
        }
    }
}
