<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/jquery-2.1.1.min.js")"></script>
    @Html.DevExpress().GetStyleSheets(New DevExpress.Web.Mvc.UI.StyleSheet With {.ExtensionSuite = DevExpress.Web.Mvc.UI.ExtensionSuite.GridView},
                                     New DevExpress.Web.Mvc.UI.StyleSheet With {.ExtensionSuite = DevExpress.Web.Mvc.UI.ExtensionSuite.NavigationAndLayout})
    @Html.DevExpress().GetScripts(New DevExpress.Web.Mvc.UI.Script With {.ExtensionSuite = DevExpress.Web.Mvc.UI.ExtensionSuite.GridView},
                                  New DevExpress.Web.Mvc.UI.Script With {.ExtensionSuite = DevExpress.Web.Mvc.UI.ExtensionSuite.NavigationAndLayout})
    <script type="text/javascript">
        $(document).ajaxSuccess(function () {
            document.getElementById("logDiv").innerHTML += "<p>Callback complete</p>";
        });
        MVCxClientGlobalEvents.AddControlsInitializedEventHandler(function (s, e) {
            if (e.isCallback == true) {
                document.getElementById("logDiv").innerHTML += "<p>MVCxClientGlobalEvents callback complete</p>";
            }
        });
    </script>
</head>

<body>
    @RenderBody()
</body>
</html>
