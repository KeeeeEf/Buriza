using Buriza.Web.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Buriza.Web.Components.Layout;

public partial class MainLayout
{
    [Inject]
    public required AppStateService AppStateService { get; set; }
    
    public MudTheme BurizaTheme => new()
    {
        PaletteDark = new()
        {
            Background = "#101921",
        },
        PaletteLight = new()
        {
            Background = "#E8FFFE",
        },  
    };
}