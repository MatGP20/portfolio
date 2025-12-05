using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWASMPortfolio.Pages
{
    public partial class Aboutme
    {
        [Inject] private IJSRuntime JS {  get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JS.InvokeVoidAsync("startCarrousel");

            await JS.InvokeVoidAsync("autoRealScroll", ".textBlock");            

            await base.OnAfterRenderAsync(firstRender);
        }

    }
}
