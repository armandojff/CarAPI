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
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllCarsController
    {
        readonly IGetAllCarsInputPort InputPort;
        readonly IGetAllCarsOutputPort OutputPort;

        public GetAllCarsController(IGetAllCarsInputPort inputPort, IGetAllCarsOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpGet]

        public async Task <IEnumerable<CarDTO>> GetAllCars()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<CarDTO>>)OutputPort).Content;

        }
    }
}
