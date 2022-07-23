using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace FlappyInsect.Module.Insect
{
    public class InsectView : ObjectView<IInsectModel>
    {
        private UnityAction _onCollideWithObstacle;
        private UnityAction _onTroughObstacleHole;
        private UnityAction<GameObject> _onTroughCoin;

        public void SetCallbacks(UnityAction onCollideWithObstacle, UnityAction onTroughObstacleHole, UnityAction<GameObject> onTroughCoin)
        {
            _onCollideWithObstacle = onCollideWithObstacle;
            _onTroughObstacleHole = onTroughObstacleHole;
            _onTroughCoin = onTroughCoin;
        }

        protected override void InitRenderModel(IInsectModel model)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>($"Sprites/Insect/{model.Name}")[0];
            GetComponent<Animator>().SetTrigger(model.Name);
        }

        protected override void UpdateRenderModel(IInsectModel model)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>($"Sprites/Insect/{model.Name}")[0];
            GetComponent<Animator>().SetTrigger(model.Name);
        }

        private void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            bool isCollideWithGround = collisionInfo.gameObject.CompareTag("Ground");
            bool isCollideWithObstacle = collisionInfo.gameObject.CompareTag("Obstacle");
            if (isCollideWithGround || isCollideWithObstacle)
            {
                GetComponent<CircleCollider2D>().enabled = false;
                _onCollideWithObstacle?.Invoke();
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            bool isTroughObstacleHole = other.gameObject.CompareTag("Hole");
            bool isTroughCoin = other.gameObject.CompareTag("Coin");
            if (isTroughObstacleHole)
            {
                _onTroughObstacleHole?.Invoke();
            }
            else if (isTroughCoin)
            {
                _onTroughCoin?.Invoke(other.gameObject);
            }
        }
    }
}
