using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(services =>
    {
        services.AddScoped<MyDBContext>(options => new MyDBContext("Server=127.0.0.1,1433; Database=MyTestDb; User=sa; Password =HAL@VSCPassword123;"));
    })
    .Build();

//Calling EnsureCreated in Program
using (var context = host.Services.GetService<MyDBContext>())
{
    context.Database.EnsureCreated(); 
}


host.Run();
