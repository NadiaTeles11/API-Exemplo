using NC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NC.Domain.Entities.Veiculo
{
    public class NcVeiculo : BaseEntity
    {
        public string Placa { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }
    }
}
