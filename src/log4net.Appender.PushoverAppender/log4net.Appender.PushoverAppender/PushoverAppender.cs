using PushoverClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net.Appender
{
    public class PushoverAppender : AppenderSkeleton
    {
        public string ApplicationName { get; set; }
        public string ApplicationKey { get; set; }
        public string UserKey { get; set; }

        public Pushover pclient { get; set; }

        protected override void Append(Core.LoggingEvent loggingEvent)
        {
            pclient = new Pushover(ApplicationKey);

            var response = pclient.Push(
              string.Format("{0} - {1}", loggingEvent.Level.Name, ApplicationName),
              loggingEvent.RenderedMessage,
              UserKey
          );
        }
    }
}
