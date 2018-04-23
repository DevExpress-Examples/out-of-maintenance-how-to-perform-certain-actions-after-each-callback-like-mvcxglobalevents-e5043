# How to perform certain actions after each callback (like MVCxGlobalEvents)


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


