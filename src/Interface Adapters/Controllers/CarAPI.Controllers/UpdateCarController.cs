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
    public class UpdateCarController
    {
        readonly IUpdateCarInputPort InputPort;
        readonly IUpdateCarOutputPort OutputPort;

        public UpdateCarController(IUpdateCarInputPort inputPort, IUpdateCarOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpPut]

        public async Task<UpdateCarDTO> UpdateCar(
            UpdateCarDTO car)
        {
            await InputPort.Handle(car);
            return ((IPresenter<UpdateCarDTO>)OutputPort).Content;
        }
    }
}
