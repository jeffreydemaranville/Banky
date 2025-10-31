using Banky.Repositories;
using Banky.Repositories.Interfaces;
using Banky.Repositories.Models;
using Banky.Services;
using Banky.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBankAccountService, BankAccountService>();
builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();
builder.Services.AddSingleton<List<AccountDetail>>(
    [
        new AccountDetail() { AccountId = 1001, AccountStatusId = 1, AccountTypeId = 1, Balance = 33721.55, CustomerId = 1 },
        new AccountDetail() { AccountId = 2001, AccountStatusId = 1, AccountTypeId = 1, Balance = 1525.22, CustomerId = 2 },
        new AccountDetail() { AccountId = 3001, AccountStatusId = 1, AccountTypeId = 2, Balance = 23.22, CustomerId = 3 },
        new AccountDetail() { AccountId = 4001, AccountStatusId = 0, AccountTypeId = 2, Balance = 0, CustomerId = 4 },
    ]);

builder.Services.AddSingleton<List<CustomerDetail>>(
    [
        new CustomerDetail() { CustomerId = 1, },
        new CustomerDetail() { CustomerId = 2, },
        new CustomerDetail() { CustomerId = 3, },
        new CustomerDetail() { CustomerId = 4, },
        new CustomerDetail() { CustomerId = 5, }
    ]);
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
