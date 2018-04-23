@Code
    Dim grid = Html.DevExpress().GridView(Sub(settings)
        settings.Name = "GridView"
		settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}


		settings.KeyFieldName = "ModelID"

		settings.SettingsPager.Visible = True
		settings.Settings.ShowGroupPanel = True
		settings.Settings.ShowFilterRow = True
		settings.SettingsBehavior.AllowSelectByRowClick = False

		settings.Columns.Add("ModelID")
		settings.Columns.Add("ModelName")
		settings.Columns.Add("ModelState")
		settings.Columns.Add("ModelDate")
    End Sub)
End Code
@grid.Bind(Model).GetHtml()