// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sakuri.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Sakuri;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Sakuri.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Sakuri.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Sakuri.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Sakuri.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/scouri/Programming/C#/Sakuri/Pages/MonthlyExpenses.razor"
using Sakuri.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monthlyexpenses")]
    public partial class MonthlyExpenses : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/home/scouri/Programming/C#/Sakuri/Pages/MonthlyExpenses.razor"
       
    [CascadingParameter] public IModalService Modal { get; set; }
    private MoneyInformation[] forecasts;
    int totalCost;
    void ShowModal()
    {
        var options = new ModalOptions()
        {
            HideCloseButton = true,
            Animation = ModalAnimation.FadeInOut(.25)
        };

        Modal.Show<AddProduct>("Products", options);
    }
    protected override async Task OnInitializedAsync()
    {
        forecasts = await MoneyService.GetMoneyAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MoneyInformationService MoneyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
