using System.ComponentModel.DataAnnotations;

namespace locadora_braga.Models
{
    public class Cliente
    {
        [Key]
        public string cpf { get; set; }

        public string name { get; set; }

        public bool excluido { get; set; }

        public Cliente()
        {
            cpf = string.Empty;
            name = string.Empty;
            excluido = false;
        }
    }
}
