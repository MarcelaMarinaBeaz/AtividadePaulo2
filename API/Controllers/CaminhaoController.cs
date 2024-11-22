using AutoMapper;
using Core._1_Service.Interface;
using Core.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private readonly ICaminhaoService _service;
        private readonly IMapper _mapper;

        public CaminhaoController(ICaminhaoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost("Adicionar_Caminhao")]
        public long AdicionarCaminhao(Caminhao caminhao)
        {
            return _service.AdicionarCaminhao(caminhao);
        }

        [HttpGet("Listar_Caminhao")]
        public List<Caminhao> ListarCaminhao()
        {
            return _service.ListarCaminhao();
        }

        [HttpPut("Editar_Caminhao")]
        public void EditarCaminhao(Caminhao caminhao)
        {
            _service.EditarCaminhao(caminhao);
        }

        [HttpDelete("Deletar_Caminhao")]
        public void DeletarCaminhao(int id)
        {
            _service.DeletarCaminhao(id);
        }
    }
}
