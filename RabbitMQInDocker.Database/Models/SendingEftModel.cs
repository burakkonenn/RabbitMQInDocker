using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQInDocker.Database.Models
{
    public class SendingEftModel
    {
        public int FromId { get; set; }
        public int ToId { get; set; }
        public double Money { get; set; }
    }
}
