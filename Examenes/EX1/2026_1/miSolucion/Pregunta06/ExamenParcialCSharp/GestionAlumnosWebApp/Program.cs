using BO.Clases.BO;
using BO.Clases.BOI;
using GestionAlumnosWebApp.Components;
using DBManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registrar el BO: "cuando alguien pida IAlumnoBO, entrégale un AlumnoBOImpl"
builder.Services.AddScoped<IAlumnoBO, AlumnoBOImpl>();

// Inicializar el DBManager con la cadena del appsettings.json
string? cadena = builder.Configuration.GetConnectionString("MySqlConnection");
DBmanager.Instance.Inicializar(cadena);

var app = builder.Build();
// ... el resto queda igual
