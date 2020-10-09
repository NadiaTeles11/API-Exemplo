using NexcodeControls.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace NC.Domain.Entities.Garagem
{
    public class NcVagaGaragem : BaseEntity
    {
        public string Vaga { get; set; }

        public int Tipo { get; set; }
    }
}
