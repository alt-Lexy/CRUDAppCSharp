using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// to use bootstrap
app.UseStaticFiles();

// middleware
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*app.MapGet("/", (HttpContext context) =>
{
    string html = @$"
<!doctype html>
<html>
<body>
<h1>Hello </h1>
<br/>
<form action=""/login"" method=""post"" class=""form-example"">
  <div class=""form-example"">
    <label for=""username"">user: </label>
    <input type=""text"" name=""username"" id=""username"" required />
  </div>
  <div class=""form-example"">
    <label for=""password"">password: </label>
    <input type=""password"" name=""password"" id=""password"" required />
  </div>
  <div class=""form-example"">
    <input type=""submit"" value=""login"" />
  </div>
</form>
</body>
</html>";

    WriteHtml(context, html);
});*/

/*app.MapPost("/login", (HttpContext context) =>
{
    var username = context.Request.Form["username"];
    var password = context.Request.Form["password"];

    if (username == "john" && password == "bingo")
    {
        string html = @$"
<!doctype html>
<html>
<body>
<h1>welcome john ! </h1>
<br/>
</body>
</html>";

        WriteHtml(context, html);

    }
    else
    {
        string html = @$"
<!doctype html>
<html>
<body>
<h1>Hello </h1>
<br/>
<form action=""/login"" method=""post"" class=""form-example"">
  <div class=""form-example"">
    <label for=""username"">user: </label>
    <input type=""text"" name=""username"" id=""username"" required />
  </div>
  <div class=""form-example"">
    <label for=""password"">Password: </label>
    <input type=""password"" name=""password"" id=""password"" required/>
  </div>
  <div class=""form-example"">
    <input type=""submit"" value=""login"" />
  </div>
<div>
    <label style=""color:red"">login failed!</label>
</div>
</form>
</body>
</html>";

        WriteHtml(context, html);
    }

});*/

app.Run();

void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);
}
