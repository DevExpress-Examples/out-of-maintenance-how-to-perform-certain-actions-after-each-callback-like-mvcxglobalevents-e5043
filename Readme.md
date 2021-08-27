<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566839/13.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5043)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/AjaxTest/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AjaxTest/Controllers/HomeController.vb))
* [MyModel.cs](./CS/AjaxTest/Models/MyModel.cs) (VB: [MyModel.vb](./VB/AjaxTest/Models/MyModel.vb))
* [_CallbackPanelPartial.cshtml](./CS/AjaxTest/Views/Home/_CallbackPanelPartial.cshtml)
* [_GridViewPartial.cshtml](./CS/AjaxTest/Views/Home/_GridViewPartial.cshtml)
* [Index.cshtml](./CS/AjaxTest/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/AjaxTest/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to perform certain actions after each callback (like MVCxGlobalEvents)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5043)**
<!-- run online end -->


<p>The main idea is to handle the <a href="http://api.jquery.com/ajaxsuccess/">jQuery.ajaxSuccess</a> event for the document element, which is raised after each callback.</p>


```js
 $(document).ajaxSuccess(function () {
     .................      
 });
```


<p><br />Starting with v.13.2, we've introduced the MVCxClientGlobalEvents object (see <a href="https://www.devexpress.com/Support/Center/p/S38527">ASP.NET MVC - Provide the capability to handle the CallbackError event globally (implement an ASPxGlobalEvents equivalent)</a>) <br />It's possible to use the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMVCScriptsMVCxClientGlobalEvents_ControlsInitializedtopic">MVCxClientGlobalEvents.ControlsInitialized</a> event handler for this purpose: </p>


```js
  MVCxClientGlobalEvents.AddControlsInitializedEventHandler(function (s, e) {
            if (e.isCallback) {
                //some action
            }
   });

```


<p> </p>
<p>Note that this event will be raised only for DevExpress callbacks.<br /><strong><br /></strong><strong>See also: <br /></strong><a href="http://api.jquery.com/Ajax_Events/">Ajax Events</a></p>

<br/>


