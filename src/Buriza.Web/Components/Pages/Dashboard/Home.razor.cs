using Buriza.Web.Services;
using Microsoft.AspNetCore.Components;

namespace Buriza.Web.Components.Pages;

public partial class Home
{
    [Inject]
    public required AppStateService AppStateService { get; set; }
    
    [Inject]
    public required IconService IconService { get; set; }

    protected string SelectedAccount { get; set; } = "Account 1";
}