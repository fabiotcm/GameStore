using System;
using GameStore.Api.Data;
using GameStore.Api.Dtos;
using GameStore.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Endpoints;

public static class GenresEndpoints
{
    public static void MapGenresEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/genres");

        // Get /genres
        group.MapGet("/", async (GameStoreContext dbContext) => 
        await dbContext.Genres
        .Select(Genre => new GenreDto(Genre.Id, Genre.Name))
        .AsNoTracking()
        .ToListAsync());
    }
}
