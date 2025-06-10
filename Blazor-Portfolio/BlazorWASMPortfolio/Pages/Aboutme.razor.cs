using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWASMPortfolio.Pages
{
    public partial class Aboutme
    {
        [Inject] IJSRuntime Js { get; set;}

        //protected override async Task OnAfterRenderAsync(bool firstRender)
        //{
        //    await Js.InvokeVoidAsync("startAllCarousel");
        //}
    }
}
