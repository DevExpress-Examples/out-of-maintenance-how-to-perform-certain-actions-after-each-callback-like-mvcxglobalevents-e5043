@Code
    ViewBag.Title = "Index"
End Code

<h2>How to implement certain actions after each callback</h2>

@Html.Action("CallbackPanelPartial")

@Html.DevExpress().Button(Sub(settings)
   settings.Name = "Button"
	settings.UseSubmitBehavior = False
	settings.Text = "Send a callback"
	settings.ClientSideEvents.Click = "function(s,e){CallbackPanel.PerformCallback();}"
End Sub).GetHtml()

@Html.Action("GridViewPartial")
