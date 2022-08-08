namespace FlappyInsect.Message
{
    public struct InsectChangeMessage
    {
        public string Name { get; private set; }

        public InsectChangeMessage(string name)
        {
            Name = name;
        }
    }
}


