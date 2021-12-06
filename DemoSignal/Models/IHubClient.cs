using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSignal.Models
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
