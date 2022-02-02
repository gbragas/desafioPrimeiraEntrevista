using System.ComponentModel.DataAnnotations;

namespace locadora_braga.Models
{
    public class Filme
    {
        [Key]
        public string id { get; set; }

        public string name { get; set; }

        public bool excluido { get; set; }

        public Filme()
        {
            id = string.Empty;
            name = string.Empty;
            excluido = false;
        }
    }
}
