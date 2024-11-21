using AutoMapper;
using Core._1_Service.Interface;
using Core.Entidade;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class VeiculoController : ControllerBase
{
    private readonly IVeiculoService _service;
    private readonly IMapper _mapper;

    public VeiculoController(IVeiculoService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost("Adicionar_Veiculo")]
    public void AdicionarVeiculo(Veiculo v)
    {
        _service.AdicionarVeiculo(v);
    }

    [HttpGet("Listar_Veiculos")]
    public List<Veiculo> ListarVeiculos()
    {
        return _service.ListarVeiculo();
    }

    [HttpPut("Editar_Veiculo")]
    public void EditarVeiculo(Veiculo v)
    {
        _service.EditarVeiculo(v);
    }

    [HttpDelete("Deletar_Veiculo")]
    public void DeletarVeiculo(int id)
    {
        _service.DeletarVeiculo(id);
    }
}
