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
            BackgroundGray = "#2B2B4A",
            Dark = "#2C2D42",
            DarkLighten = "#2C2D42",
            Primary = "#227CFF",
            TextPrimary = "#E8EFFB",
            TextSecondary = "#838C9E",
            Divider = "#2C2D42",
            Success = "#7BFFB2"
        },
        PaletteLight = new()
        {
            Background = "#E8EFFB",
            AppbarBackground = "#EEEEEE",
            Dark = "#2C2D4226",
            DarkLighten = "#E8EFFB",
            Primary = "#227CFF",
            TextPrimary = "#445671",
            TextSecondary = "#7E8EA5",
            Divider = "#FFFFFF",
            Success = "#7BFFB2"
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