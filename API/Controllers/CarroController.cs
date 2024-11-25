using AutoMapper;
using Dominio._01_Core.Entidades.DTOs.Veiculos;
using Dominio._01_Core.Interfaces.Services;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    private readonly ICarroService _service;
    private readonly IMapper _mapper;
    public CarroController(IMapper mapper, ICarroService service)
    {
        _mapper = mapper;
        _service = service;
    }
    [HttpPost("adicionar-carro")]
    public IActionResult AdicionarCarro(CreateCarroDTO carroDTO)
    {
        try
        {
            Carro carro = _mapper.Map<Carro>(carroDTO);
            _service.Adicionar(carro);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpPost("calcular-consumo")]
    public ActionResult<double> CalcularConsumoCarro(int id, double distancia)
    {
        try
        {
            Carro carro = _service.BuscarPorId(id);
            return Ok(carro.CalcularConsumo(distancia));
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpGet("listar-carro")]
    public ActionResult<List<Carro>> ListarCarro()
    {
        try
        {
            return Ok(_service.Listar());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }

    }
    [HttpGet("exibir-detalhes-carro")]
    public ActionResult<string> DetalhesDoCarro(int id)
    {
        try
        {
            Carro carro = _service.BuscarPorId(id);
            return Ok(carro.ExibirDetalhes());
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }

    }
    [HttpPut("editar-carro")]
    public IActionResult EditarCarro(Carro p)
    {
        try
        {
            _service.Editar(p);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("deletar-carro")]
    public IActionResult DeletarCarro(int id)
    {
        try
        {
            _service.Remover(id);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
