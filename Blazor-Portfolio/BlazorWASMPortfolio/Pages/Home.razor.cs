using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWASMPortfolio.Pages
{
    public partial class Home
    {
        [Inject] private IJSRuntime JS { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JS.InvokeVoidAsync("startCarrousel");
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
