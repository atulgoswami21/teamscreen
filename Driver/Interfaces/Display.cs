﻿using Common.EventArgs.Network;
using Network;
using Network.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver.Interfaces
{
    public interface Display
    {
        void RequestScreenshot(ScreenshotRequestEventArgs e, Boolean fullscreen);

        void SetManager(HostManager hostManager);

        void RemoveClient(string clientSystemId);
        void RemoveAllClients();
    }
}
