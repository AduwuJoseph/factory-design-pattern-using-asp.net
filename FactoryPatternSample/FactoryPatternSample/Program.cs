using FactoryPatternSample.Core.Factory;
using FactoryPatternSample.Core.Interfaces;
using FactoryPatternSample.Core.Services.Movies;
using FactoryPatternSample.Core.Services.Payments;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); }); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<StreamFactory>();

/************** Modern Way Approach Services Registration *************************/
builder.Services.AddScoped<PaymentChannelFactory>();
builder.Services.AddScoped<IFcmbEasyPayHelper, FcmbEasyPayHelperService>();

builder.Services.AddScoped<FcmbEasyPayService>()
			.AddScoped<IPaymentChannel, FcmbEasyPayService>(s => s.GetService<FcmbEasyPayService>());

builder.Services.AddScoped<RemitaPaymentService>()
			.AddScoped<IPaymentChannel, RemitaPaymentService>(s => s.GetService<RemitaPaymentService>());

builder.Services.AddScoped<PayStackService>()
			.AddScoped<IPaymentChannel, PayStackService>(s => s.GetService<PayStackService>());
builder.Services.AddScoped<FlutterwaveService>()
			.AddScoped<IPaymentChannel, FlutterwaveService>(s => s.GetService<FlutterwaveService>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
