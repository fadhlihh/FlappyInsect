namespace FlappyInsect.Message
{
    public class UpdateSfxConfigMessage
    {
        public bool IsSfxOn { get; private set; }
        public UpdateSfxConfigMessage(bool isSfxOn)
        {
            IsSfxOn = isSfxOn;
        }
    }
}
