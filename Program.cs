using HoneyRaesAPICSHARP.Models;
List<Customer> customers = new List<Customer>
{
    new Customer { Id = 1, Name = "Alice Johnson", Address = "123 Main St" },
    new Customer { Id = 2, Name = "Bob Smith", Address = "456 Elm St" },
    new Customer { Id = 3, Name = "Charlie Brown", Address = "789 Oak St" }
};


List<Employee> employees = new List<Employee>
{
    new Employee { Id = 1, Name = "Emily Davis", Specialty = "HVAC" },
    new Employee { Id = 2, Name = "John Miller", Specialty = "Plumbing" }
};

List<ServiceTicket> serviceTickets = new List<ServiceTicket>
{
    // Assigned to Employee 1, Completed
    new ServiceTicket
    {
        Id = 1,
        CustomerId = 1,
        EmployeeId = 1,
        Description = "Heating system maintenance",
        Emergency = false,
        DateCompleted = new DateOnly(2024, 6, 1)
    },
    // Assigned to Employee 2, Incomplete
    new ServiceTicket
    {
        Id = 2,
        CustomerId = 2,
        EmployeeId = 2,
        Description = "Leaking kitchen sink",
        Emergency = true
    },
    // No Employee assigned, Incomplete
    new ServiceTicket
    {
        Id = 3,
        CustomerId = 3,
        Description = "Broken air conditioner",
        Emergency = true
    },
    // Assigned to Employee 1, Completed
    new ServiceTicket
    {
        Id = 4,
        CustomerId = 1,
        EmployeeId = 1,
        Description = "Install thermostat",
        Emergency = false,
        DateCompleted = new DateOnly(2024, 6, 5)
    },
    // No Employee assigned, Incomplete
    new ServiceTicket
    {
        Id = 5,
        CustomerId = 2,
        Description = "Clogged shower drain",
        Emergency = false
    }
};



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.UseHttpsRedirection();


app.Run();

