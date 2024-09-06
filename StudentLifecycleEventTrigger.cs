using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MMU.StudentLifecycle
{
    public class StudentLifecycleEventTrigger
    {
        [FunctionName("StudentLifecycleEventTrigger")]
        public void Run([ServiceBusTrigger("StudentLifecycleTopic", "WelcomeLetterGeneratorSubscription", Connection = "")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
