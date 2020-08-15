using System;

namespace Hangfire.Topshelf.Sample.WindowsService.WindowsService
{
    public class WindowsServiceBuilder: IWindowsServiceBuilder
    {
        public string ServiceName => "TestService";
        public string ServiceDisplayName => "Test Service";
        public string ServiceDescription => "This is for test";
        public void BuildService()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Continue()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
