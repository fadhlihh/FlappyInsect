using System.Collections;
using Agate.MVC.Base;
using FlappyInsect.Message;
using FlappyInsect.Module.ProgressData;

namespace FlappyInsect.Module.HUD
{
    public class HUDController : ObjectController<HUDController, HUDModel, IHUDModel, HUDView>
    {
        private ProgressDataController _progressData;

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetHighScore(_progressData.Model.Progress.HighScore);
            _model.SetTotalCoin(_progressData.Model.Progress.Coin);
        }

        public override void SetView(HUDView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnSetting, OnInsectSelection, OnShop, OnGamePause);
        }

        public void OnPurchaseInsect(PurchaseInsectMessage message)
        {
            int totalCoin = _model.TotalCoin - message.Cost;
            _model.SetTotalCoin(totalCoin);
        }

        public void OnStartPlay(StartPlayMessage message)
        {
            _model.SetIsPlaying(true);
        }

        public void OnUpdateScore(UpdateScoreMessage message)
        {
            _model.SetScore(message.Score);
        }

        public void OnUpdateCoin(UpdateCoinMessage message)
        {
            _model.SetCoin(message.Coin);
        }

        private void OnSetting()
        {
            Publish<ShowSettingMessage>(new ShowSettingMessage());
        }

        private void OnInsectSelection()
        {
            Publish<ShowInsectSelectionMessage>(new ShowInsectSelectionMessage());
        }

        private void OnShop()
        {
            Publish<ShowShopMessage>(new ShowShopMessage());
        }

        private void OnGamePause()
        {
            Publish<ShowGamePauseMessage>(new ShowGamePauseMessage());
        }
    }
}
