using System.Globalization;

namespace Buriza.Web.Services;

public class AppStateService
{
    public bool IsDarkMode { get; set; } = true;
    public event EventHandler<EventArgs>? Changed;
    public void NotifyChanged() => Changed?.Invoke(this, EventArgs.Empty);
}