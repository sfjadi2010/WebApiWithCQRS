using Carter;
using MediatR;
using WebApiWithCQRS.Features.Books.Queries.Get;

namespace WebApiWithCQRS.Endpoints;

public class BooksModule : ICarterModule
{
    public async void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/books/{id:guid}", async (Guid id, ISender mediatr) =>
        {
            var book = await mediatr.Send(new GetBookQuery(id));
        });
    }
}
