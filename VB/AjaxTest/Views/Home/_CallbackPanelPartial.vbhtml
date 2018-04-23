@Html.DevExpress().CallbackPanel(Sub(settings)

    settings.Name = "CallbackPanel"
	settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "CallbackPanelPartial"}
	settings.Width = 500
	settings.Height = 300
    settings.ControlStyle.Border.BorderStyle = System.Web.UI.WebControls.BorderStyle.Dashed
    settings.ControlStyle.Border.BorderColor = System.Drawing.Color.Black
    settings.SetContent(Sub()
  
        ViewContext.Writer.Write("Callback Panel content")
    End Sub)
End Sub).GetHtml()