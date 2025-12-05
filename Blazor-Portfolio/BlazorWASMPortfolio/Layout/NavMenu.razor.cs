using Microsoft.AspNetCore.Components;

namespace BlazorWASMPortfolio.Layout
{
    public partial class NavMenu : ComponentBase
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
            await ChangeTittle();
        }

        private async Task ChangeTittle()
        {
            await Task.Delay(500);
            var pageUri = navMgr.Uri.Split("/", StringSplitOptions.RemoveEmptyEntries);
            switch (pageUri[pageUri.Length - 1])
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
            await InvokeAsync(StateHasChanged);
        }
    }
}
