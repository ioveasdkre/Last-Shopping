using LastShopping.Database.DbContextModel;
using LastShopping.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<LastShoppingDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("LastShoppingDb")));

builder.Services.AddDbContextPool<UserAppDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("UserAppDb")));

// 將 Helper結尾且生命週期相同的物件,統一註冊
builder.Services.Scan(scan => scan
        .FromAssemblyOf<Program>() // 1.遍歷Startup類別所在程序集中的所有類別
        .AddClasses(classes => // 2.要自動註冊的類別,條件為 Helper結尾的類別
            classes.Where(t => t.Name.EndsWith("Helper", StringComparison.OrdinalIgnoreCase)))
        .AsImplementedInterfaces() // 3.註冊的類別有實作界面
        .WithScopedLifetime() // 4.生命週期設定為Scoped
);

// DI注入
builder.Services.AddScoped<AppSettingsUtils>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 會自動轉成https請求，沒關閉的話http的請求都會被擋住
app.UseHttpsRedirection();

// 套用驗證在路由
app.UseAuthorization();

app.MapControllers();

app.Run();
