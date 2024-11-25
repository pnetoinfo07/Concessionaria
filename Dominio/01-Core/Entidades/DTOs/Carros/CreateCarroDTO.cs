using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Entidades.DTOs.Veiculos;

public class CreateCarroDTO : CreateVeiculoDTO 
{
    public string Tipo { get; set; }
}
