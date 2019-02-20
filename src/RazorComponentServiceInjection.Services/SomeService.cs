using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace RazorComponentServiceInjection.Services
{
    public class SomeService
    {
        public async Task<string> PromptAsync(string message)
        {
            // Implemented in exampleJsInterop.js
            return await JSRuntime.Current.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
