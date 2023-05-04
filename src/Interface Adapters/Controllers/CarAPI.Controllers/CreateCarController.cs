using CarAPI.DTOs;
using CarAPI.Port;
using CarAPI.Presenters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    /// <summary>
    /// Controller that receives HTTP requests from the client.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCarController
    {
        readonly ICreateCarInputPort InputPort;
        readonly ICreateCarOutputPort OutputPort;

        public CreateCarController(ICreateCarInputPort inputPort, ICreateCarOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }
        /// <summary>
        /// POST method that sends data to create a new car in the database.
        /// </summary>
        [HttpPost]

        public async Task <CarDTO> CreateCar(
            CreateCarDTO car)
        {
            await InputPort.Handle(car);
            return ((IPresenter<CarDTO>)OutputPort).Content;
        }
    }
}
