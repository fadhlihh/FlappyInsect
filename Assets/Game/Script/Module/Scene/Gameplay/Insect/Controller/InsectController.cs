using System.Collections;
using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.ProgressData;

namespace FlappyInsect.Module.Insect
{
    public class InsectController : ObjectController<InsectController, InsectModel, IInsectModel, InsectView>
    {
        private ProgressDataController _progressData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetName(_progressData.Model.Progress.SelectedInsect.Name);
        }

        public override void SetView(InsectView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnCollideWithObstacle, OnTroughObstacleHole, OnTroughCoin);
        }

        public void OnInsectChange(InsectChangeMessage message)
        {
            _model.SetName(message.Name);
        }

        public void OnStartPlay(StartPlayMessage message)
        {
            _view.GetComponent<Rigidbody2D>().gravityScale = _model.GravityScale;
        }

        public void OnMoveInsect(MoveInsectMessage message)
        {
            Vector2 force = Vector2.up * _model.Force * Time.fixedDeltaTime;
            _view.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Force);
        }

        private void OnCollideWithObstacle()
        {
            Publish<GameOverMessage>(new GameOverMessage());
        }

        private void OnTroughObstacleHole()
        {
            Publish<AddScoreMessage>(new AddScoreMessage());
        }

        private void OnTroughCoin(GameObject triggeredCoin)
        {
            Publish<AddCoinMessage>(new AddCoinMessage(triggeredCoin));
        }
    }
}
