namespace Hangfire.Topshelf.Sample.WindowsService.WindowsService
{
    public interface IWindowsService
    {
        string ServiceName { get; }
        string ServiceDisplayName { get; }
        string ServiceDescription { get; }
        void Start();
        void Stop();
        void Continue();
        void Pause();
        void Shutdown();
    }
}
