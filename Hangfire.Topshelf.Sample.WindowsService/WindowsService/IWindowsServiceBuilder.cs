namespace Hangfire.Topshelf.Sample.WindowsService.WindowsService
{
    public interface IWindowsServiceBuilder
    {
        string ServiceName { get; }
        string ServiceDisplayName { get; }
        string ServiceDescription { get; }
        void BuildService();
        void Start();
        void Stop();
        void Continue();
        void Pause();
        void Shutdown();
    }
}
