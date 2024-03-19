using System.Numerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {

        [Key]
        public int Id { get; set; }
        public string  Marca { get; set;}

        public string Processador { get; set;}
        [DisplayName("Placa Mãe")]
        public string PlacaMae { get; set; }

        public int Memoria { get; set; }

        public int HD { get; set; }
        [DisplayName("Numero Patrimonio")]
        public int NumeroPatrimonio { get; set; }
        [DisplayName("Data De Compra")]
        [DataType(DataType.Date)]
        public string DataDeCompra { get; set; }


    

    }
}
