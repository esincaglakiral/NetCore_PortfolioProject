using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>();  //identity register iþlemleri için yazýlan attribute
builder.Services.AddDbContext<Context>();


builder.Services.AddScoped<IAboutDal, EFAboutDal>(); 
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IContactDal, EFContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IExperienceDal, EFExperienceDal>();
builder.Services.AddScoped<IExperienceService, ExperienceManager>();


builder.Services.AddScoped<IEducationDal, EFEducationDal>();
builder.Services.AddScoped<IEducationService, EducationManager>();


builder.Services.AddScoped<IFeatureDal, EFFeatureDal>();
builder.Services.AddScoped<IFeatureService, FeatureManager>();


builder.Services.AddScoped<IMessageDal, EFMessageDal>();
builder.Services.AddScoped<IMessageService, MessageManager>();

builder.Services.AddScoped<IPortfolioDal, EFPortfolioDal>();
builder.Services.AddScoped<IPortfolioService, PortfolioManager>();

builder.Services.AddScoped<IServiceDal, EFServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();


builder.Services.AddScoped<ISkillDal, EFSkillDal>();
builder.Services.AddScoped<ISkillService, SkillManager>();


builder.Services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();


builder.Services.AddScoped<ITestimonialDal, EFTestimonalDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder()
	.RequireAuthenticatedUser()
	.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});


builder.Services.AddMvc();

builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.ExpireTimeSpan = TimeSpan.FromMinutes(60); //Panelde kalma süresi
	options.AccessDeniedPath = "/ErrorPage/Index/";
	options.LoginPath = "/Writer/Login/Index/";

});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");  // hata sayfasý yönlendirme

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.UseAuthentication();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>   //area kýsmýnýn çalýþmasý için Scaffolding dosyasýndan bu kodun konfigurasyonunu burada saðlamamýz gerek.
{
	endpoints.MapControllerRoute(
	  name: "areas",
	  pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
	);
});

app.Run();
