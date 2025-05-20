using Microsoft.AspNetCore.Components;

namespace BlazorWebPortfolio.Components.Layout
{
    public partial class NavMenu 
    {
        private string? pageTittle;

        [Inject] private NavigationManager navMgr {  get; set; }

        protected override Task OnInitializedAsync()
        {
            ChangeTittle();
            return base.OnInitializedAsync();
        }

        private async void ChangeTittle()
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
