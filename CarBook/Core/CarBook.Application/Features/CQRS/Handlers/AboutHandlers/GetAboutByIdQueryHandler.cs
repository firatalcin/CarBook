using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request)
        {
            var about = await _repository.GetByIdAsync(request.Id);
            return new GetAboutByIdQueryResult
            {
                Id = about.Id,
                Description = about.Description,
                ImageUrl = about.ImageUrl,
                Title = about.Title
            };
        }
    }
}
