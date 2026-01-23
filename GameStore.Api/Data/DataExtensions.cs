using System;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

// Escopo que dá acesso para capturar e criar uma instância do GameStoreContext e aplicar as migrations pendentes
public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        dbContext.Database.Migrate();
    }
}
