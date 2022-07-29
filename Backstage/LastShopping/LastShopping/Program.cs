using LastShopping.Database.DbContextModel;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<LastShoppingDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("LastShoppingDb")));

builder.Services.AddDbContextPool<UserAppDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("UserAppDb")));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// 此方法內設定值為資安設定            
app.Use(async (context, next) =>
{
    // 當您單擊網站上的鏈接時，調用 URL 會自動轉移到鏈接的站點。除非這是必要的，否則您應該使用Referrer-Policy標頭禁用它：
    context.Response.Headers.Add("Referrer-Policy", "strict-origin-when-cross-origin");

    // MIME 類型的嗅探是一種攻擊，黑客試圖利用所提供文件上丟失的元數據進行攻擊。可以在中間件中添加標頭：
    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");

    // CFO(與 CSP相同，此為舊方法，因為並非所有瀏覽器都支援 frame-ancestors，所以 支援度較廣的 X-Frame-Options 還是可以和  CSP 一起採用。)
    context.Response.Headers.Add("X-Frame-Options", "DENY");

    // 您可能沒有使用 Flash。對？對！！？如果沒有，您可以禁用 Flash 使用X-Permitted-Cross-Domain-Policies標頭進行跨站點請求的可能性：
    context.Response.Headers.Add("X-Permitted-Cross-Domain-Policies", "none");

    // XSS保護
    context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");

    // 該 Permissions-Policy（原名Feature-Policy）告訴該平台擁有自己的網站需要瀏覽器。大多數網絡應用程序不需要訪問麥克風或移動瀏覽器上可用的振動器功能。為什麼不明確說明它以避免導入腳本或框架頁面做您不期望的事情：
    context.Response.Headers.Add("Permissions-Policy", "accelerometer=(),  autoplay=(), camera=(), display-capture=(), document-domain=(), encrypted-media=(), gyroscope=(), magnetometer=(), microphone=(), midi=(), payment=(), picture-in-picture=(), publickey-credentials-get=(), sync-xhr=self, usb=(), xr-spatial-tracking=(),  geolocation=()");

    // 設定CSP
    context.Response.Headers.Add(
        "Content-Security-Policy",
        "base-uri 'none'; child-src 'none'; connect-src 'self' wss:; default-src 'self' 'unsafe-inline'; font-src 'none'; form-action 'self'; frame-ancestors 'none'; frame-src 'none'; img-src 'self' data:; manifest-src 'none'; media-src 'none'; object-src 'none'; sandbox allow-downloads allow-forms allow-modals allow-same-origin allow-scripts; script-src 'self' 'unsafe-inline'; script-src-attr 'self' 'unsafe-inline'; script-src-elem 'self' 'unsafe-inline'; style-src 'self' 'unsafe-inline'; style-src-attr 'unsafe-inline'; style-src-elem 'self' 'unsafe-inline'; trusted-types 'none'; upgrade-insecure-requests; worker-src 'none';"
    );
    await next();
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
