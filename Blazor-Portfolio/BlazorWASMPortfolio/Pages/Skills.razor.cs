using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWASMPortfolio.Pages
{
    public partial class Skills
    {
        private string frontCard = "expand";
        private string backCard = "small";
        private string othersCard = "small";

        [Inject] private IJSRuntime JS { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await AutoScrollSkill(".frontBlock");
            }

            await base.OnAfterRenderAsync(firstRender);
        }

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
                    //await AutoScrollSkill(".frontBlock");
                    break;
                case 2:
                    frontCard = "small";
                    backCard = "expand";
                    othersCard = "small";
                    await AutoScrollSkill(".backBlock");
                    break;
                case 3:
                    frontCard = "small";
                    backCard = "small";
                    othersCard = "expand";
                    await AutoScrollSkill(".othersBlock");
                    break;
                default:
                    break;
            }

            await InvokeAsync(StateHasChanged);

            
        }

        private async Task AutoScrollSkill (string block)
        {
            await JS.InvokeVoidAsync("autoRealScroll", block);
        }
    }
}
