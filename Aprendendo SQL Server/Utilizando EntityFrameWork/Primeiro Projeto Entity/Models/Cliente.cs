using System;
using System.Collections.Generic;

namespace Primeiro_projeto_Entity.Models;

public partial class Cliente
{
    public int IdClient { get; set; }

    public string Nome { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public decimal? Salario { get; set; }
}
