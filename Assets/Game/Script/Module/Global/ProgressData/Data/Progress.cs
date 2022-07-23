using System.Collections.Generic;
using FlappyInsect.Module.InsectsData;

namespace FlappyInsect.Module.ProgressData
{
    [System.Serializable]
    public class Progress
    {
        public int HighScore;
        public int Coin;
        public List<InsectData> Insects;
        public InsectData SelectedInsect;
    }
}
