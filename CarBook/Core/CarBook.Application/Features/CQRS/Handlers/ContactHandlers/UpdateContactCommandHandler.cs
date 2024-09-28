using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand request)
        {
            var value = await _repository.GetByIdAsync(request.Id);

            value.SendDate = request.SendDate;
            value.Subject = request.Subject;
            value.Email = request.Email;
            value.Message = request.Message;
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
