using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.ProgressData;
using FlappyInsect.Module.Shop;
using FlappyInsect.Module.InsectSelection;
using FlappyInsect.Module.HUD;
using FlappyInsect.Module.CoinCalculator;
using FlappyInsect.Module.CoinPool;
using FlappyInsect.Module.GameplayAudio;


namespace FlappyInsect.Scene.Gameplay
{
    public class GameplayConnector : BaseConnector
    {
        private ProgressDataController _progressData;
        private ShopController _shopController;
        private InsectSelectionController _insectSelection;
        private HUDController _hud;
        private CoinCalculatorController _coinCalculator;
        private CoinPoolController _coinPool;
        private GameplayAudioController _gameplayAudio;
        protected override void Connect()
        {
            Subscribe<PurchaseInsectMessage>(OnPurchaseInsect);
            Subscribe<AddCoinMessage>(OnAddCoin);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PurchaseInsectMessage>(OnPurchaseInsect);
            Unsubscribe<AddCoinMessage>(OnAddCoin);
        }

        private void OnPurchaseInsect(PurchaseInsectMessage message)
        {
            _progressData.OnPurchaseInsect(message);
            _shopController.OnPurchaseInsect(message.Cost);
            _insectSelection.OnPurchaseInsect();
            _hud.OnPurchaseInsect(message.Cost);
        }

        private void OnAddCoin(AddCoinMessage message)
        {
            _coinCalculator.OnAddCoin();
            _coinPool.OnAddCoin(message.Coin);
            _gameplayAudio.OnAddCoin();
        }
    }
}
