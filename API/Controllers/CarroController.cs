using AutoMapper;
using Core._1_Service.Interface;
using Core._3_Entidade.DTOs;
using Core.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _service;
        private readonly IMapper _mapper;

        public CarroController(ICarroService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost("Adicionar_Carro")]
        public long AdicionarCarro(Carro carro)
        {
           return _service.AdicionarCarro(carro);
        }

        [HttpGet("Listar_Carro")]
        public List<Carro> ListarCarro()
        {
            return _service.ListarCarro();
        }

        [HttpPut("Editar_Carro")]
        public void EditarCarro(Carro c)
        {
            _service.EditarCarro(c);
        }

        [HttpDelete("Deletar_Carro")]
        public void DeletarCarro(int id)
        {
            _service.DeletarCarro(id);
        }
    }
}
