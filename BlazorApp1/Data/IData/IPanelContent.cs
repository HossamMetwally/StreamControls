using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Data.IData
{
    public interface IPanelContent
    {
        //Blazor's way of representing a piece of UI that can be rendered.
        RenderFragment RenderContent();

    }
}
