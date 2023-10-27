using MinimalApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                policy =>
                {
                    policy.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin(); // Não é recomendado fazer isso
                });
});
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();


var ordems = CrudServicos.GetServicos();
app.MapGet("/OrdemServico", () => ordems);
app.MapGet("/OrdemServico/{id}", (string id) => CrudServicos.Get(id));
app.MapPost("/OrdemServico", (OrdemServico ordemServico) => CrudServicos.Post(ordemServico));
app.MapDelete("/OrdemServico/{id}", (string id) => CrudServicos.Delete(id));
app.MapPut("/OrdemServico/{id}", (string id,OrdemServico ordemServico) => CrudServicos.Update(id,ordemServico));

app.Run();

