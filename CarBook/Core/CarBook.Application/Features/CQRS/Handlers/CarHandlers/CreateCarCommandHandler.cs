using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand request)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = request.BigImageUrl,
                BrandId = request.BrandId,
                Fuel = request.Fuel,
                Km = request.Km,
                Model = request.Model,
                Luggage = request.Luggage,
                Transmission = request.Transmission,
                Seat = request.Seat,
                CoverImageUrl = request.CoverImageUrl,
            });
        }
    }
}
