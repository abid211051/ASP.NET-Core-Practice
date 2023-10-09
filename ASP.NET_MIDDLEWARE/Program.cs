var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
const string name = "Afnan";


//for multiple middleware use app.Use()
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("first asp.net project\n");
    await next(context);
});
app.Use(async (context, next) =>
{
    List<int> list = new();
    for(int i = 0; i < 10; i++)
    {
        list.Add(i);
    }
    for(int i = 0;i < list.Count; i++)
    {
        await context.Response.WriteAsync($"{list[i]}\n");
    }
    await next(context);
});

app.Use(async (context, next) =>
{
    if (name.Equals("Abid"))
    {
        await context.Response.WriteAsync("This is valid user\n");
    }
    else
    {
        await context.Response.WriteAsync("Unauthorized User, Get Lost\n");
    }
    await next(context);
});
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Middleware Run in every Request");
});


app.Run();
