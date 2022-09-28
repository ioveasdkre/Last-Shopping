using LastShopping.Database.DbContextModel;
using LastShopping.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<LastShoppingDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("LastShoppingDb")));

builder.Services.AddDbContextPool<UserAppDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("UserAppDb")));

// �N Helper�����B�ͩR�g���ۦP������,�Τ@���U
builder.Services.Scan(scan => scan
        .FromAssemblyOf<Program>() // 1.�M��Startup���O�Ҧb�{�Ƕ������Ҧ����O
        .AddClasses(classes => // 2.�n�۰ʵ��U�����O,���� Helper���������O
            classes.Where(t => t.Name.EndsWith("Helper", StringComparison.OrdinalIgnoreCase)))
        .AsImplementedInterfaces() // 3.���U�����O����@�ɭ�
        .WithScopedLifetime() // 4.�ͩR�g���]�w��Scoped
);

// DI�`�J
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

// �|�۰��নhttps�ШD�A�S��������http���ШD���|�Q�צ�
app.UseHttpsRedirection();

// �M�����Ҧb����
app.UseAuthorization();

app.MapControllers();

app.Run();
