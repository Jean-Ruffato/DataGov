using System;
using System.Collections.Generic;
using System.Text;

namespace DataGov.Core.Model
{
    public class AcordosLenienciaTO
    {
        public string nomeEmpresa { get; set; }
        public int id { get; set; }
        public string dataInicioAcordo { get; set; }
        public string dataFimAcordo { get; set; }
        public string orgaoResponsavel { get; set; }
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string nomeFantasia { get; set; }
        public string ufEmpresa { get; set; }
        public string situacaoAcordo { get; set; }
        public int quantidade { get; set; }
    }
}
