using MediatR;
using WebApiWithCQRS.Features.Books.Dtos;

namespace WebApiWithCQRS.Features.Books.Queries.Get;

public record GetBookQuery(Guid Id) : IRequest<BookDto>;
