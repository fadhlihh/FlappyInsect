namespace FlappyInsect.Message
{
    public struct PurchaseInsectMessage
    {
        public string Name { get; private set; }
        public int Cost { get; private set; }

        public PurchaseInsectMessage(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
