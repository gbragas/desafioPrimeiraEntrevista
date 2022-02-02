using System.ComponentModel.DataAnnotations;
using System;

namespace locadora_braga.Models
{
    public class Locacao
    {
        [Key]
        public string id { get; set; }

        public DateTime dataHoje { get; set; }

        public DateTime dataPrazo { get; set; }

        [Required]
        public string cpfCliente { get; set; }

        [Required]
        public string idFilme { get; set; }

        public bool excluido { get; set; }

        public Locacao()
        {
            id = string.Empty;
            cpfCliente = string.Empty;
            idFilme = string.Empty;
            dataHoje = DateTime.Now;
 
        }
    }
}
