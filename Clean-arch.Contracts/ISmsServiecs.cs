using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_arch.Contracts
{
    public interface ISmsServiecs
    {
        void SendSms(SmsBody body);
    }
    public class SmsBody()
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}
