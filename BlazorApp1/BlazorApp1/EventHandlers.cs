using Microsoft.AspNetCore.Components;

namespace BlazorApp1
{
    [EventHandler("onchangestatevent", typeof(ChangeStatArgs), enableStopPropagation: true, enablePreventDefault: true)]
    public static class EventHandlers
    {
        
    }
}