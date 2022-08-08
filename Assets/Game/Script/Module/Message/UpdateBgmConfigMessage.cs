namespace FlappyInsect.Message
{
    public struct UpdateBgmConfigMessage
    {
        public bool IsBgmOn { get; private set; }
        public UpdateBgmConfigMessage(bool isBgmOn)
        {
            IsBgmOn = isBgmOn;
        }
    }
}
