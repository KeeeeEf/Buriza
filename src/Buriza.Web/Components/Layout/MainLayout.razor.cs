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
            Background = "#030303",
            AppbarBackground = "#0E0E0E",
            Primary = "#227CFF",
            TextPrimary = "#E8EFFB",
            TextSecondary = "#838C9E",
            Success = "#7BFFB2"
        },
        PaletteLight = new()
        {
            Background = "#E8EFFB",
            AppbarBackground = "#EEEEEE",
            Primary = "#227CFF",
            TextPrimary = "#445671",
            TextSecondary = "#7E8EA5"
        },  
        Typography = new()
        {
            Default = new DefaultTypography()
            {
                FontFamily = ["Poppins", "sans-serif"]
            }
        },
    };
}