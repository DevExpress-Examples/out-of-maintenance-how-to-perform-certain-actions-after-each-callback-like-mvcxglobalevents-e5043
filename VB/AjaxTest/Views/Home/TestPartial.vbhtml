@Html.DevExpress().Label(Sub(settings)
                             settings.Name = "Label"
                             settings.Text = DateTime.Now.ToString()
                         End Sub).GetHtml()