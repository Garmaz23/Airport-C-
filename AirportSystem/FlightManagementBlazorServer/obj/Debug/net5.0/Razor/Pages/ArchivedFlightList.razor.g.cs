#pragma checksum "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd8104df7fbad91169b159f44546708b3ba1128"
// <auto-generated/>
#pragma warning disable 1591
namespace FlightManagementBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using FlightManagementBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using DomainModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\_Imports.razor"
using ValidationModels;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/archivedFlightList")]
    public partial class ArchivedFlightList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Archived Flights</h3>");
#nullable restore
#line 6 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
 if(Flights == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 9 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-responsive");
            __builder.AddMarkupContent(4, "<thead><tr><th>Number</th>\n                <th>Date</th>\n                <th>Time</th>\n                <th>Carrier</th>\n                <th>Airport to</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 23 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
             foreach(var flight in Flights)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 26 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(8, flight.Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 27 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(11, flight.FlightDate.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 28 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(14, flight.FlightTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 29 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(17, flight.Carrier?.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 30 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
__builder.AddContent(20, flight.AirportTo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\PC HOME\OneDrive - CARNET\Desktop\AirportSystem-main\FlightManagementBlazorServer\Pages\ArchivedFlightList.razor"
       
    public List<Flight> Flights { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Flights = await _flightService.GetArchivedFlights();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlightService _flightService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
