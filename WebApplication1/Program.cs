var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*app.MapGet("/", () => "Hello World!");

app.Run();

await app.StartAsync();
await Task.Delay(10000);
await app.StopAsync();

/*app.UseWelcomePage();
app.Run();

app.Run(test);
app.MapGet("/", () => $"Деление 45/5={45 / 5}");*/

/*app.Run(async (context) =>
{
    var response = context.Response;
    //response.Headers.ContentLanguage = "ru-Ru";
    //response.Headers.ContentType = "text/plain; charset=utf-8";
    //response.Headers.Append("secret-id", "256");
    //await response.WriteAsync("Привет студенты");

    /* context.Response.StatusCode = 404;
     await context.Response.WriteAsync("Resource not found");*/

/*await response.WriteAsync("<h2>hello world</h2><h3>welcome to asp.net</h3>"); v
await response.SendFileAsync("C:\\HTML\\JS\\clock.html");

 response.ContentType = "text/html; charset=utf-8";
 var stringBuilder = new System.Text.StringBuilder("<table>");
 foreach (var header in context.Request.Headers)
 {
     stringBuilder.Append($"<tr><td>{header.Key}<td><td>{header.Value}<td><tr>");
 }
 stringBuilder.Append("</table>");
 await context.Response.WriteAsync(stringBuilder.ToString());

var acceptValue = context.Request.Headers.Accept;
await response.WriteAsync(acceptValue);


var path = context.Request.Path;
var now = DateTime.Now;

if (path == "/date")
{
    await response.WriteAsync($"Date: {now.ToShortDateString()}");
}
else if (path == "/time")
{
    await response.WriteAsync($"Time: {now.ToShortTimeString()}");
}
else
{
    await response.WriteAsync("Hello World");
}*/

/*  response.ContentType = "text/html; charset=utf-8";
  var stringBuilder = new System.Text.StringBuilder();
 // stringBuilder.Append("<tr><td>Параметр</td><td>Значение</td></tr>");

  foreach (var text in context.Request.Query)
  {
      stringBuilder.Append(text.Value + " ");
  }
});
*/

/*app.Map("/date", () => $"Date: {DateTime.Now.ToString()}");
app.Map("/day", () => "Monday");
app.Map("/", () => "Hello world");

async Task test(HttpContext context)
{
    await context.Response.WriteAsync(" // Require that the Title is not null.  //  Use custom validation error.");
}
app.Run(async (context) => await context.Response.WriteAsync("TEST"));*/

/*app.Run(async (context) => await context.Response.SendFileAsync("C:\\HTML\\pole.jpg"));
app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("html/index.html");
});*/

/*app.Map("/date", async (context) => await context.Response.SendFileAsync("html/date.html"));
app.Map("/time", async (context) => await context.Response.SendFileAsync("html/clock.html"));
app.Map("/Welcome", async (context) => await context.Response.SendFileAsync("html/Welcome.html"));
app.Map("/", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("html/index.html");
});*/


/*app.Map("/", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("html/index.html");
});*/

/*app.Map("/t1", async (context) =>
{
    var fileProfider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
    var fileInfo = fileProfider.GetFileInfo("html/pole.jpg");
    context.Response.Headers.ContentDisposition = "attachment; filename=my_C3.jpg";
    await context.Response.SendFileAsync(fileInfo);
});
app.Map("/t2",async (context) =>
{
    var fileProfider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
    var fileInfo = fileProfider.GetFileInfo("html/58c4646ae056615abf2841a7.jpg");
    context.Response.Headers.ContentDisposition = "attachment; filename=my_C1.jpg";
    await context.Response.SendFileAsync(fileInfo);
});
app.Map("/", async (context) =>
{
    var fileProfider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
    var fileInfo = fileProfider.GetFileInfo("html/1692037.jpg");
    context.Response.Headers.ContentDisposition = "attachment; filename=my_C2.jpg";
    await context.Response.SendFileAsync(fileInfo);
});*/

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    /* if (context.Request.Path == "/postuser")
     {
         var form = context.Request.Form;
         string name = form["name"];
         string age = form["age"];
         List<string> lang = form["languages"].ToList();
         await context.Response.WriteAsync($"<div><p>Name: {name}</p>" +
             $"<p>Age: {age}</p><p>{String.Join(" ", lang)}<p/></div>");
     }*/
    /* if (context.Request.Path == "/old")
     {
         context.Response.Redirect("https://instagram.com");
     }
     else if (context.Request.Path == "/new")
     {
         await context.Response.WriteAsync("new page");
     }
     else {
         await context.Response.WriteAsync("main page");
     }*/

    /* Human ted = new("Ted", 25);
     var text = JsonSerializer.Serialize(ted);
     await context.Response.WriteAsync(text);
    // await context.Response.WriteAsJsonAsync(ted);*/

    var response = context.Response;
    var request = context.Request;
    if (request.Path == "/postuser")
    {
        var message = "Некорректные данные";
        var person = await request.ReadFromJsonAsync<Human>();
        if (person != null)
        {
            message = $"Name: {person.Name}  Age: {person.Age}";            
        }

        await response.WriteAsJsonAsync(new { text = message });
    }
    else
    {
        await context.Response.SendFileAsync("html/form.html");
    }

});
app.Run();

public record Human(string Name, int Age);