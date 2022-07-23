namespace FlappyInsect.Message
{
    public class UpdateBgmConfigMessage
    {
        public bool IsBgmOn { get; private set; }
        public UpdateBgmConfigMessage(bool isBgmOn)
        {
            IsBgmOn = isBgmOn;
        }
    }
}
