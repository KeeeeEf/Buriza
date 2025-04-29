namespace Buriza.Web.Services;

public class IconService(IWebHostEnvironment env)
{
    private readonly Dictionary<string, string> _cache = [];

    public string ActiveNetworksIcon => _cache.TryGetValue("active_networks_icon.svg", out string? value) ? value : LoadIcon("active_networks_icon.svg");
    public string AdaIcon => _cache.TryGetValue("ada_icon.svg", out string? value) ? value : LoadIcon("ada_icon.svg");
    public string AddIcon => _cache.TryGetValue("add_icon.svg", out string? value) ? value : LoadIcon("add_icon.svg");
    public string AddressBookIcon => _cache.TryGetValue("address_book_icon.svg", out string? value) ? value : LoadIcon("address_book_icon.svg");
    public string AdvanceSettings1 => _cache.TryGetValue("advance_settings_1.svg", out string? value) ? value : LoadIcon("advance_settings_1.svg");
    public string AdvanceSettings => _cache.TryGetValue("advance_settings.svg", out string? value) ? value : LoadIcon("advance_settings.svg");
    public string AssetsIcon => _cache.TryGetValue("assets_icon.svg", out string? value) ? value : LoadIcon("assets_icon.svg");
    public string BurizaIcon => _cache.TryGetValue("buriza_icon.svg", out string? value) ? value : LoadIcon("buriza_icon.svg");
    public string CheckIcon => _cache.TryGetValue("check_icon.svg", out string? value) ? value : LoadIcon("check_icon.svg");
    public string ChevronDownIcon => _cache.TryGetValue("chevron_down_icon.svg", out string? value) ? value : LoadIcon("chevron_down_icon.svg");
    public string ChevronLeftIcon => _cache.TryGetValue("chevron_left_icon.svg", out string? value) ? value : LoadIcon("chevron_left_icon.svg");
    public string ChevronRightIcon => _cache.TryGetValue("chevron_right_icon.svg", out string? value) ? value : LoadIcon("chevron_right_icon.svg");
    public string CloseIcon => _cache.TryGetValue("close_icon.svg", out string? value) ? value : LoadIcon("close_icon.svg");
    public string ConnectedAppsIcon => _cache.TryGetValue("connected_apps_icon.svg", out string? value) ? value : LoadIcon("connected_apps_icon.svg");
    public string CopyIcon => _cache.TryGetValue("copy_icon.svg", out string? value) ? value : LoadIcon("copy_icon.svg");
    public string DarkModeIcon => _cache.TryGetValue("dark_mode_icon.svg", out string? value) ? value : LoadIcon("dark_mode_icon.svg");
    public string DeleteIcon => _cache.TryGetValue("delete_icon.svg", out string? value) ? value : LoadIcon("delete_icon.svg");
    public string DeveloperSettingsIcon => _cache.TryGetValue("developer_settings_icon.svg", out string? value) ? value : LoadIcon("developer_settings_icon.svg");
    public string EditIcon => _cache.TryGetValue("edit_icon.svg", out string? value) ? value : LoadIcon("edit_icon.svg");
    public string FilterIcon => _cache.TryGetValue("filter_icon.svg", out string? value) ? value : LoadIcon("filter_icon.svg");
    public string HelpAndSupportIcon => _cache.TryGetValue("help_and_support_icon.svg", out string? value) ? value : LoadIcon("help_and_support_icon.svg");
    public string HistoryIcon => _cache.TryGetValue("history_icon.svg", out string? value) ? value : LoadIcon("history_icon.svg");
    public string InviteIcon => _cache.TryGetValue("invite_icon.svg", out string? value) ? value : LoadIcon("invite_icon.svg");
    public string LightModeIcon => _cache.TryGetValue("light_mode_icon.svg", out string? value) ? value : LoadIcon("light_mode_icon.svg");
    public string NftIcon => _cache.TryGetValue("nft_icon.svg", out string? value) ? value : LoadIcon("nft_icon.svg");
    public string NodeIcon => _cache.TryGetValue("node_icon.svg", out string? value) ? value : LoadIcon("node_icon.svg");
    public string ReceiveIcon => _cache.TryGetValue("receive_icon.svg", out string? value) ? value : LoadIcon("receive_icon.svg");
    public string RefreshIcon => _cache.TryGetValue("refresh_icon.svg", out string? value) ? value : LoadIcon("refresh_icon.svg");
    public string RemoveIcon => _cache.TryGetValue("remove_icon.svg", out string? value) ? value : LoadIcon("remove_icon.svg");
    public string RemoveOutlinedIcon => _cache.TryGetValue("remove_outlined_icon.svg", out string? value) ? value : LoadIcon("remove_outlined_icon.svg");
    public string ScanIcon => _cache.TryGetValue("scan_icon.svg", out string? value) ? value : LoadIcon("scan_icon.svg");
    public string SearchIcon => _cache.TryGetValue("search_icon.svg", out string? value) ? value : LoadIcon("search_icon.svg");
    public string SecurityAndPrivacyIcon => _cache.TryGetValue("security_and_privacy_icon.svg", out string? value) ? value : LoadIcon("security_and_privacy_icon.svg");
    public string SendIcon => _cache.TryGetValue("send_icon.svg", out string? value) ? value : LoadIcon("send_icon.svg");
    public string SettingsIcon => _cache.TryGetValue("settings_icon.svg", out string? value) ? value : LoadIcon("settings_icon.svg");
    public string SidebarIcon => _cache.TryGetValue("sidebar_icon.svg", out string? value) ? value : LoadIcon("sidebar_icon.svg");
    public string TokenIcon => _cache.TryGetValue("token_icon.svg", out string? value) ? value : LoadIcon("token_icon.svg");
    public string UnusedIcon => _cache.TryGetValue("unused_icon.svg", out string? value) ? value : LoadIcon("unused_icon.svg");
    public string WalletIcon => _cache.TryGetValue("wallet_icon.svg", out string? value) ? value : LoadIcon("wallet_icon.svg");
    public string WarningInfoIcon => _cache.TryGetValue("warning_info_icon.svg", out string? value) ? value : LoadIcon("warning_info_icon.svg");

    public string LoadIcon(string iconName)
    {
        string iconPath = Path.Combine(env.WebRootPath, "images", "icons", iconName);
        if (File.Exists(iconPath))
        {
            _cache[iconName] = File.ReadAllText(iconPath);
        }
        return _cache[iconName];
    }
}