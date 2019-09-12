using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class MessageService
    {
        public void OnVideo(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending text..." + e.Video.Title);
        }
    }
}
