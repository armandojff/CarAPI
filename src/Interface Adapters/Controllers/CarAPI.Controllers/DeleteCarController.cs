using CarAPI.DTOs;
using CarAPI.Port;
using CarAPI.Presenters;
using CarAPI.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteCarController
    {
        readonly IDeleteCarInputPort InputPort;
        readonly IDeleteCarOutputPort OutputPort;

        public DeleteCarController(IDeleteCarInputPort inputPort, IDeleteCarOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpDelete]

        public async Task<DeleteCarDTO> DeleteCar(
            DeleteCarDTO car)
        {
            await InputPort.Handle(car);
            return ((IPresenter<DeleteCarDTO>)OutputPort).Content;
        }
    }

}
