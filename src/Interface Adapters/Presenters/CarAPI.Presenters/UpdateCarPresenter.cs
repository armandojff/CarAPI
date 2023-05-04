using CarAPI.DTOs;
using CarAPI.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Presenters
{
    public class UpdateCarPresenter : IUpdateCarOutputPort, IPresenter<UpdateCarDTO>
    {
        public UpdateCarDTO Content { get; private set; }

        public Task Handle(UpdateCarDTO car)
        {
            Content = car;
            return Task.CompletedTask;
        }
    }
}
