// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sakuri.Pages.Accout
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
#line 11 "/home/scouri/Programming/C#/Sakuri/_Imports.razor"
using Sakuri.Data;

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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(Layout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/account/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/home/scouri/Programming/C#/Sakuri/Pages/Accout/Register.razor"
       
    private AddUser model = new AddUser();
    private bool loading;

    private async void OnValidSubmit()
    {
        loading = true;
        try
        {
            await AccountService.Register(model);
            NavigationManager.NavigateTo("account/login");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            loading = false;
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
