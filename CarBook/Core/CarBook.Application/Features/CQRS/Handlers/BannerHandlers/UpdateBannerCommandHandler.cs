using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand request)
        {
            var values = await _repository.GetByIdAsync(request.Id);

            values.VideoDescription = request.VideoDescription;
            values.Title = request.Title;
            values.VideoUrl = request.VideoUrl;
            values.Description = request.Description;
            
            await _repository.UpdateAsync(values);
            
        }
    }
}
