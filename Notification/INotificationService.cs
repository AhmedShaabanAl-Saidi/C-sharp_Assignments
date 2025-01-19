using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_.Notification
{
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
