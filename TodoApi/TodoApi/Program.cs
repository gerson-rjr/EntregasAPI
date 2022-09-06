using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.IncludeFields = true;
});

var app = builder.Build();


Entrega entrega = new Entrega(1, 1, DateTime.Now);
Entrega entrega2 = new Entrega(2, 2, DateTime.Now);

List<Entrega> ListaEntregas = new List<Entrega>();

ListaEntregas.Add(entrega);
ListaEntregas.Add(entrega2);


app.MapGet("/", () => "Entregas \n\n GET /delivery para visualizar a lista de Entregas; \n POST /delivery para enviar uma nova ordem de Entrega.");
app.MapGet("/delivery", () => ListaEntregas);

app.MapPost("/delivery", (Entrega NovaEntrega) =>
{
    ListaEntregas.Add(NovaEntrega);
    return Results.Created($"/delivery/{NovaEntrega.Id}", NovaEntrega);
});


app.Run();

class Entrega{
    public int Id { get; set; }
    public int NumEntrega { get; set; }
    public DateTime DataEntrega { get; set; }

    public Entrega(){}
    public Entrega(int Id, int NumEntrega, DateTime DataEntrega)
    {
        this.Id = Id;
        this.NumEntrega = NumEntrega;  
        this.DataEntrega = DataEntrega; 
    }
}
