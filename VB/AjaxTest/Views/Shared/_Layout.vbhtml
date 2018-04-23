<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/jquery-1.7.1.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/modernizr-2.5.3.js")" type="text/javascript"></script>
   @Html.DevExpress().GetStyleSheets(New DevExpress.Web.Mvc.UI.StyleSheet With {.ExtensionSuite = DevExpress.Web.Mvc.UI.ExtensionSuite.All}) 
    @Html.DevExpress().GetScripts(New DevExpress.Web.Mvc.UI.Script With {.ExtensionSuite = DevExpress.Web.Mvc.UI.ExtensionSuite.All})
</head>

<body>
    <div id="myDiv" style="display:none;"></div>
     <script type="text/javascript">
         $('#myDiv').ajaxSuccess(function () {
             alert('Callback complete');
         });
	</script>
    @RenderBody()
</body>
</html>
