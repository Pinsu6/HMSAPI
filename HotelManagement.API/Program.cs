using Microsoft.EntityFrameworkCore;
using HotelManagement.Data.Contexts;
using HotelManagement.Data.Repositories;
using HotelManagement.Data.Repositories.Interface;
using HotelManagement.Business.Manager;
using HotelManagement.Business.Manager.Interface;
using HotelManagement.Services.Room;
using HotelManagement.Services.Room.Interface;
using HotelManagement.Services.Booking;
using HotelManagement.Services.Booking.Interface;
using HotelManagement.Services.Charge;
using HotelManagement.Services.Charge.Interface;
using HotelManagement.Services.Customer;
using HotelManagement.Services.Customer.Interface;
using HotelManagement.Services.Guest;
using HotelManagement.Services.Guest.Interface;
using HotelManagement.Services.Invoice;
using HotelManagement.Services.Invoice.Interface;
using HotelManagement.Services.Order;
using HotelManagement.Services.Order.Interface;
using HotelManagement.Services.Payment;
using HotelManagement.Services.Payment.Interface;
using HotelManagement.Services.RoomType;
using HotelManagement.Services.RoomType.Interface;
using HotelManagement.Services.User;
using HotelManagement.Services.User.Interface;
using HotelManagement.Services.Login;
using HotelManagement.Services.Login.Interface;
using HotelManagement.Services.WiFiLog;
using HotelManagement.Services.WiFiLog.Interface;
using HotelManagement.Services.Dashboard;
using HotelManagement.Services.Dashboard.Interface;
using HotelManagement.Services.Currency;
using HotelManagement.Services.Currency.Interface;
using HotelManagement.Services.AddServices;
using HotelManagement.Services.AddServices.Interface;
using HotelManagement.Services.Hotel;
using HotelManagement.Services.Hotel.Interface;
using HotelManagement.Services.Notification;
using HotelManagement.Services.Notification.Interface;
using HotelManagement.Services.Tax;
using HotelManagement.Services.Tax.Interface;
using HotelManagement.Services.Floor;
using HotelManagement.Services.Floor.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor(); // For dynamic URL generation in Invoice PDF
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.SetIsOriginAllowed(_ => true) // Allow any origin
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .AllowCredentials() // Allow cookies/auth headers
                   .WithExposedHeaders("Content-Disposition", "Content-Length", "X-Total-Count"); // Expose headers for file downloads etc.
        });
});

builder.Services.AddDbContext<HotelDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IRoomManager, RoomManager>();
builder.Services.AddScoped<IRoomService, RoomService>();

builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IBookingManager, BookingManager>();
builder.Services.AddScoped<IBookingService, BookingService>();

builder.Services.AddScoped<IChargeRepository, ChargeRepository>();
builder.Services.AddScoped<IChargeManager, ChargeManager>();
builder.Services.AddScoped<IChargeService, ChargeService>();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerManager, CustomerManager>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<IGuestRepository, GuestRepository>();
builder.Services.AddScoped<IGuestManager, GuestManager>();
builder.Services.AddScoped<IGuestService, GuestService>();

builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddScoped<IInvoiceManager, InvoiceManager>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderManager, OrderManager>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentManager, PaymentManager>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

builder.Services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
builder.Services.AddScoped<IRoomTypeManager, RoomTypeManager>();
builder.Services.AddScoped<IRoomTypeService, RoomTypeService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ILoginManager, LoginManager>();
builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddScoped<IWiFiLogRepository, WiFiLogRepository>();
builder.Services.AddScoped<IWiFiLogManager, WiFiLogManager>();
builder.Services.AddScoped<IWiFiLogService, WiFiLogService>();

builder.Services.AddScoped<IDashboardRepository, DashboardRepository>();
builder.Services.AddScoped<IDashboardManager, DashboardManager>();
builder.Services.AddScoped<IDashboardService, DashboardService>();

builder.Services.AddScoped<ICurrencyRepository, CurrencyRepository>();
builder.Services.AddScoped<ICurrencyManager, CurrencyManager>();
builder.Services.AddScoped<ICurrencyService, CurrencyService>();

builder.Services.AddScoped<IAddServicesRepository, AddServicesRepository>();
builder.Services.AddScoped<IAddServicesManager, AddServicesManager>();
builder.Services.AddScoped<IAddServicesService, AddServicesService>();

builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IHotelManager, HotelManager>();
builder.Services.AddScoped<IHotelService, HotelService>();

builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<INotificationManager, NotificationManager>();
builder.Services.AddScoped<INotificationService, NotificationService>();

builder.Services.AddScoped<ITaxRepository, TaxRepository>();
builder.Services.AddScoped<ITaxManager, TaxManager>();
builder.Services.AddScoped<ITaxService, TaxService>();

builder.Services.AddScoped<IFloorRepository, FloorRepository>();
builder.Services.AddScoped<IFloorManager, FloorManager>();
builder.Services.AddScoped<IFloorService, FloorService>();

var app = builder.Build();

// CORS must be the FIRST middleware to handle preflight requests before any redirect
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
// Enable Swagger for all environments (not just development)
app.UseSwagger();
app.UseSwaggerUI();

// Do NOT use HTTPS redirection - it causes preflight redirect issues
//app.UseHttpsRedirection();

// Enable serving static files (for Invoice PDFs)
app.UseStaticFiles();

// Handle OPTIONS preflight requests explicitly
app.Use(async (context, next) =>
{
    if (context.Request.Method == "OPTIONS")
    {
        context.Response.StatusCode = 200;
        await context.Response.CompleteAsync();
        return;
    }
    await next();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
