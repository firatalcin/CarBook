using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand request)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            value.Transmission = request.Transmission;
            value.BigImageUrl = request.BigImageUrl;
            value.BrandId = request.BrandId;
            value.CoverImageUrl= request.CoverImageUrl;
            value.Km = request.Km;
            value.Fuel = request.Fuel;
            value.Luggage = request.Luggage;
            value.Model = request.Model;
            value.Seat = request.Seat;
            
            await _repository.UpdateAsync(value);
        }
    }
}
