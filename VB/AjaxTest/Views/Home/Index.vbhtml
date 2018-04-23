@Code
    ViewBag.Title = "Index"
End Code
<script>
    function CustomRequest() {
        $.ajax({
            url: '@Url.Action("TestPartial", "Home")',
            type: "GET",
            success: function (data) {
                $('#ajaxDiv').html(data);
            },
            error: function (xhr, textStatus, errorThrown) {
                alert('Request Status: ' + xhr.status + '; Status Text: ' + textStatus + '; Error: ' + errorThrown);
            }
        });
    }
</script>
<h2>How to implement certain actions after each callback</h2>

Log:
<div id="logDiv" style="width: 500px; height: 100px; overflow: auto; margin-bottom: 10px">
</div>

<div id="ajaxDiv" style="border: dashed; background-color: yellow; width: 500px; margin-bottom: 10px">
    Ajax Result
</div>
@Html.Action("CallbackPanelPartial")
@Html.Action("GridViewPartial")
@Html.DevExpress().Button(Sub(settings)
                              settings.Name = "Button"
                              settings.UseSubmitBehavior = False
                              settings.Text = "Send a callback"
                              settings.ClientSideEvents.Click = "function(s,e){CallbackPanel.PerformCallback();}"
                          End Sub).GetHtml()
@Html.DevExpress().Button(Sub(settings)
                              settings.Name = "Button1"
                              settings.UseSubmitBehavior = False
                              settings.Text = "Send  jQuery.ajax callback"
                              settings.ClientSideEvents.Click = "function(s,e){ CustomRequest();  }"
                          End Sub).GetHtml()