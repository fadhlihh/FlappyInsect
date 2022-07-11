using FlappyBird.Base.MVC;

namespace FlappyBird.Module.Bird
{
    public class BirdMovementModel : GameBaseModel
    {
        public float Force { get; private set; } = 10000f;
        public float GravityScale { get; private set; } = 0.5f;
    }
}
