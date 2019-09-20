Support for ASP.NET Core Identity was added to your project
- The code for adding Identity to your project was generated under Areas/Identity.

Configuration of the Identity related services can be found in the Areas/Identity/IdentityHostingStartup.cs file.


The generated UI requires support for static files. To add static files to your app:
1. Call app.UseStaticFiles() from your Configure method

To use ASP.NET Core Identity you also need to enable authentication. To authentication to your app:
1. Call app.UseAuthentication() from your Configure method (after static files)

The generated UI requires MVC. To add MVC to your app:
1. Call services.AddMvc() from your ConfigureServices method
2. Call app.UseMvc() from your Configure method (after authentication)
  <script id="EventEditorTemplate" type="text/x-template">
        <table class="custom-event-editor" width="100%" cellpadding="5">
            <tbody>
                <tr>
                    <td class="e-textlabel">RequesterEmail</td>
                    <td colspan="4">
                        <input id="RequesterEmail" type="text" class="e-field e-input" value="" name="RequesterEmail" style="width: 100%" />
                    </td>
                </tr>
 
                <tr>
                    <td class="e-textlabel">Laboratory</td>
                    <td colspan="4">
                        <input type="text" id="LaboratoryId" class="e-field" name="LaboratoryName" style="width: 100%" />
                    </td>
                </tr>
                <tr>
                    <td class="e-textlabel">From</td>
                    <td colspan="4">
                        <input id="Start" class="e-field" type="text" name="Start" />
                    </td>
                </tr>
                <tr>
                    <td class="e-textlabel">To</td>
                    <td colspan="4">
                        <input id="End" class="e-field" type="text" name="End" />
                    </td>
                </tr>
                <tr>
                    <td class="e-textlabel">Special Details</td>
                    <td colspan="4">
                        <textarea id="SpecialDetails" class="e-field e-input" name="SpecialDetails" rows="3" cols="50" style="width: 100%; height: 60px !important; resize: vertical"></textarea>
                    </td>
                </tr>
                <tr>
                    <td class="e-textlabel">Status</td>
                    <td colspan="4">
                        <input type="text" id="StateId" name="State" class="e-field" style="width: 100%" />
                    </td>
                </tr>
            </tbody>
        </table>
    </script>

    <script type="text/javascript">
           
           
            var dataManagerState  = ej.DataManager({
                url: "/api/Requeststate",
                adaptor: new ej.WebApiAdaptor()
            });
        function onPopupOpen(args) {
                 
     
                    if (args.type === 'Editor') {
                      
                        var statusElement = args.element.querySelector('#StateId');
                        if (!statusElement.classList.contains('e-dropdownlist')) {
                            var dropDownListObject6 = new ej.dropdowns.DropDownList({
                                placeholder: 'Choose status', value: statusElement.value,
                                dataSource: dataManagerState,
                                field: {text: 'Status', value: 'StatusId'}
                            });
                            dropDownListObject6.appendTo(statusElement);
                            statusElement.setAttribute('name', 'State');
                        }
                        var labElement = args.element.querySelector('#LaboratoryId');
                        if (!labElement.classList.contains('e-dropdownlist')) {
                            var dropDownListObject4 = new ej.dropdowns.DropDownList({
                                placeholder: 'Choose Lab', value: labElement.value,
                                dataSource: dataManagerLaboratory
                            });
                            dropDownListObject4.appendTo(labElement);
                            filterElement.setAttribute('name', 'LaboratoryId');
                        }
                        var startElement = args.element.querySelector('#Start');

                        new ej.calendars.DateTimePicker({ value: new Date(startElement.value) || new Date() }, startElement);

                        var endElement = args.element.querySelector('#End');
                        if (!endElement.classList.contains('e-datetimepicker')) {
                            new ej.calendars.DateTimePicker({ value: new Date(endElement.value) || new Date() }, endElement);
                        }
                    }
                }
            function onEventRendered(args) {
                    var categoryColor;
                    switch (args.data.StateId) {
                        case 0:
                            categoryColor = '#F57F17';
                            break;
                        case 2:
                            categoryColor = '#7fa900';
                            break;
                        case 1:
                            categoryColor = '#8e24aa';
                            break;
                    }
                    if (!args.element || !categoryColor) {
                        return;
                    }
                    var scheduleObj = document.getElementById('schedule').ej2_instances[0];
                    if (scheduleObj.currentView === 'Agenda') {
                        (args.element.firstChild).style.borderLeftColor = categoryColor;
                    } else {
                        args.element.style.backgroundColor = categoryColor;
                    }
                }
                function onActionBegin(args) {
                    if (args.requestType === 'eventCreate' || args.requestType === 'eventChange') {
                        var data;
                        if (args.requestType === 'eventCreate') {
                            data = args.data[0];
                        } else if (args.requestType === 'eventChange') {
                            data = args.data;
                        }
                        var scheduleObj = document.getElementById('schedule').ej2_instances[0];
                        if (!scheduleObj.isSlotAvailable(data.Start, data.End)) {
                            args.cancel = true;
                        }
                    }
                }

         
        
    </script>
Apps that use ASP.NET Core Identity should also use HTTPS. To enable HTTPS see https://go.microsoft.com/fwlink/?linkid=848054.
 "defaultConnection": "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-okLims6-10F86EC1-A7B9-40B3-A943-2C9C114B0BDE;MultipleActiveResultSets=False;TrustServerCertificate=False;Connection Timeout=30;",
//  "defaultConnection": "Server=tcp:oklims.database.windows.net,1433;Initial Catalog=oklimsdb_2019-08-22T22-42Z;Persist Security Info=False;User ID=garbagepatch;Password=QzpM!05^;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"