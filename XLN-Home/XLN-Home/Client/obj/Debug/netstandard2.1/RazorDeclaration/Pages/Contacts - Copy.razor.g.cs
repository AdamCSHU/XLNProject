// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace XLN_Home.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using XLN_Home.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\_Imports.razor"
using XLN_Home.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\Pages\Contacts - Copy.razor"
using XLN_Home.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contacts")]
    public partial class Contacts___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Aiden\source\repos\XLN-Home\XLN-Home\Client\Pages\Contacts - Copy.razor"
       
    private WeatherForecast[] forecasts;
    private List<Contact> ContactList { get; set; } = new List<Contact>();

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");

        ContactList.Add(new Contact(1, "Jully", "Ces"));
        ContactList.Add(new Contact(2, "Gary", "Thom"));
        ContactList.Add(new Contact(3, "Fred", " Dread"));
        ContactList.Add(new Contact(4, "Greg", "Heag"));
        ContactList.Add(new Contact(5, "Timmy", "Nook"));
    }

    private void NavigatetoChat()
    {
        NavigationManager.NavigateTo("/chat");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
