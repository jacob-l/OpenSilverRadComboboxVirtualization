using OpenSilver.Simulator;
using System;

namespace OpenSilverRadComboboxVirtualization.Simulator
{
    internal static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
