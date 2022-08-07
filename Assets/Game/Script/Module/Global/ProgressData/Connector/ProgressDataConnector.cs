using UnityEngine;
using Agate.MVC.Base;
using FlappyInsect.Message;

namespace FlappyInsect.Module.ProgressData
{
    public class ProgressDataConnector : BaseConnector
    {
        ProgressDataController _progressData;
        protected override void Connect()
        {
            Subscribe<InsectChangeMessage>(_progressData.OnChangeSelectedInsect);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InsectChangeMessage>(_progressData.OnChangeSelectedInsect);
        }
    }
}
