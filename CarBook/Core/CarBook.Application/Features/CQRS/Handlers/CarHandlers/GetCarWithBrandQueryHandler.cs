using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarWithCarQueryResult>> Handle(GetCarQuery request)
        {
            var values = await _repository.GetCarsListWithBrands();
            return values.Select(x => new GetCarWithCarQueryResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Id = x.Id,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission
            }).ToList();
        }
    }
}
