using CarAPI.DTOs;
using CarAPI.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Presenters
{
    public class DeleteCarPresenter : IDeleteCarOutputPort, IPresenter<DeleteCarDTO>
    {
        public DeleteCarDTO Content { get; private set; }

        public Task Handle(DeleteCarDTO car)
        {
            Content = car;
            return Task.CompletedTask;
        }
    }
}
