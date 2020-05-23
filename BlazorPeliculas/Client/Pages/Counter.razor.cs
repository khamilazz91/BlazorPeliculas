using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static BlazorPeliculas.Client.Shared.MainLayout;

namespace BlazorPeliculas.Client.Pages
{
    public class CounterBase : ComponentBase
    {

        [Inject] protected ServiciosSingleton Singleton { get; set; }
        [Inject] protected ServiciosTransient Transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }


        protected int currentCount = 0;
        static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }

        protected async Task IncrementCountJavaScript()
        {
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }

    }
}
