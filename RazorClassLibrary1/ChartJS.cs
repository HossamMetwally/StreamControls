using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public static class ChartJS
    {
        public static ValueTask CreateChart(IJSRuntime jsRuntime, string canvasId, string chartType, object data, object options)
        {
            return jsRuntime.InvokeVoidAsync("chartInterop.createChart", canvasId, chartType, data, options);
        }
    }
}
