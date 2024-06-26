using MediatR;
using WebApiWithCQRS.DataAccess.DbContexts;
using WebApiWithCQRS.Features.Books.Dtos;

namespace WebApiWithCQRS.Features.Books.Queries.Get;

public class GetBookQueryHandler(BooksReviewContext context)
    : IRequestHandler<GetBookQuery, BookDto>
{
    public async Task<BookDto> Handle(GetBookQuery request, CancellationToken cancellationToken)
    {
        var book = await context.Books.FindAsync(request.Id, cancellationToken);

        if (book is null)
        {
            return null!;
        }

        return new BookDto(
            book.Id,
            book.Title,
            book.Author,
            book.Genre,
            book.YearPublished);
    }
}
