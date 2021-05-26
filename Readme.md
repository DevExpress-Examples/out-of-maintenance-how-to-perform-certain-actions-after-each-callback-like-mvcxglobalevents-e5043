<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/AjaxTest/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/AjaxTest/Controllers/HomeController.vb))
* [MyModel.cs](./CS/AjaxTest/Models/MyModel.cs) (VB: [MyModel.vb](./VB/AjaxTest/Models/MyModel.vb))
* [_CallbackPanelPartial.cshtml](./CS/AjaxTest/Views/Home/_CallbackPanelPartial.cshtml)
* [_GridViewPartial.cshtml](./CS/AjaxTest/Views/Home/_GridViewPartial.cshtml)
* **[Index.cshtml](./CS/AjaxTest/Views/Home/Index.cshtml)**
* [TestPartial.cshtml](./CS/AjaxTest/Views/Home/TestPartial.cshtml)
* [_Layout.cshtml](./CS/AjaxTest/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# How to perform certain actions after each callback (like MVCxGlobalEvents)
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5043/)**
<!-- run online end -->


<p>The main idea is to handle the <a href="http://api.jquery.com/ajaxsuccess/">jQuery.ajaxSuccess</a> event for the document element, which is raised after each callback.</p>


```js
 $(document).ajaxSuccess(function () {
     .................      
 });
```


<p><br />Starting with v.13.2, we've introduced the MVCxClientGlobalEvents object (see <a href="https://www.devexpress.com/Support/Center/p/S38527">ASP.NET MVC - Provide the capability to handle the CallbackError event globally (implement an ASPxGlobalEvents equivalent)</a>) <br />It's possible to use the <a href="https://docs.devexpress.com/AspNetMvc/js-MVCxClientGlobalEvents.ControlsInitialized">MVCxClientGlobalEvents.ControlsInitialized</a> event handler for this purpose: </p>


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


