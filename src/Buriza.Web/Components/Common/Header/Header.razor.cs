using Buriza.Web.Services;
using Microsoft.AspNetCore.Components;

namespace Buriza.Web.Components.Common;

public partial class Header
{
    [Inject]
    public required AppStateService AppStateService { get; set; }
    
    [Inject]
    public required IconService IconService { get; set; }
}