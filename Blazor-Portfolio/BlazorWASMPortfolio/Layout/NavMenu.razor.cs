using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace BlazorWASMPortfolio.Layout
{
    public partial class NavMenu : ComponentBase, IDisposable
    {
        private string? pageTittle;

        private bool collapseNavMenu = true;

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        [Inject] private NavigationManager navMgr {  get; set; }

        protected override async Task OnInitializedAsync()
        {
            navMgr.LocationChanged += HandleLocationChanged;
            UpdateTitle(navMgr.Uri);
            await base.OnInitializedAsync();
        }

        private void HandleLocationChanged(object? sender, LocationChangedEventArgs e)
        {
            UpdateTitle(e.Location);
            InvokeAsync(StateHasChanged);
        }

        private void UpdateTitle(string uri)
        {
            var pageUri = new Uri(uri).AbsolutePath.Trim('/').ToLowerInvariant();
            switch (pageUri)
            {
                case "aboutme":
                    pageTittle = "ABOUT ME";
                    break;
                case "skills":
                    pageTittle = "SKILLS";
                    break;
                case "portfolio":
                    pageTittle = "PORTFOLIO";
                    break;
                case "contact":
                    pageTittle = "CONTACTO";
                    break;
                default:
                    pageTittle = string.Empty;
                    break;
            }
        }

        public void Dispose()
        {
            navMgr.LocationChanged -= HandleLocationChanged;
        }
    }
}
