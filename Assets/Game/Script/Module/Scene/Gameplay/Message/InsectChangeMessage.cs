namespace FlappyInsect.Message
{
    public class InsectChangeMessage
    {
        public string Name { get; private set; }

        public InsectChangeMessage(string name)
        {
            Name = name;
        }
    }
}


