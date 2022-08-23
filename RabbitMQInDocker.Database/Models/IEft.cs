using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQInDocker.Database.Models
{
    public interface IEft
    {
        void Send(SendingEftModel model);

        Customer GetCustomer(int userId);
    }
}
