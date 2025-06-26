namespace BlazorWASMPortfolio.Pages
{
    public partial class Skills
    {
        private string frontCard = "expand";
        private string backCard = "small";
        private string othersCard = "small";

        protected override async Task OnInitializedAsync()
        {
            await ToggleSize(1);
            await base.OnInitializedAsync();
        }

        private async Task ToggleSize(int cardId)
        {
            switch (cardId)
            {
                case 1:
                    frontCard = "expand";
                    backCard = "small";
                    othersCard = "small";
                    break;
                case 2:
                    frontCard = "small";
                    backCard = "expand";
                    othersCard = "small";
                    break;
                case 3:
                    frontCard = "small";
                    backCard = "small";
                    othersCard = "expand";
                    break;
                default:
                    break;
            }

            await InvokeAsync(StateHasChanged);
        }
    }
}
