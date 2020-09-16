using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Controller
{
    public class MyMessage
    {
        private bool status;
        private string messageText;

        public MyMessage()
        {
            this.status = false;
            this.messageText = "";
        }

        public MyMessage(bool status, String message)
        {
            this.status = status;
            this.messageText = message;
        }
        public bool Status { get => status; set => status = value; }
        public string MessageText { get => messageText; set => messageText = value; }
    }
}
