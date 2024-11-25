using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Entidades.DTOs.Veiculos;

public class CreateVeiculoDTO
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double CapacidadeTanque { get; set; }
    public double ConsumoPorKm { get; set; }

}
