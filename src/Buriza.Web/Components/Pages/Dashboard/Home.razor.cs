using Buriza.Data.Models.Common;
using Buriza.Web.Services;
using Buriza.Web.Data;
using Microsoft.AspNetCore.Components;

namespace Buriza.Web.Components.Pages;

public partial class Home
{
    [Inject]
    public required AppStateService AppStateService { get; set; }
    
    [Inject]
    public required IconService IconService { get; set; }

    protected string SelectedAccount { get; set; } = "Account 1";
    protected List<NftProfile> NftProfileList = NftProfileData.NftProfileList;
    protected List<TokenProfile> TokenProfileList = TokenProfileData.TokenProfileList;

}