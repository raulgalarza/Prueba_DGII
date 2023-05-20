using System.ComponentModel.DataAnnotations;

namespace DGII_CNTR.Model
{

    public class Contribuyentes
    {
        [Key]
        public int IdContribuyente { get; set; }
        public string rncCedula { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string estatus { get; set; }

        public List<ComprobantesFiscales> ComprobantesFiscales { get; set; }

        // public virtual ICollection<ComprobantesFiscales> ComprobantesFiscales { get; set; }

    }
    public class ComprobantesFiscales
    {
        public int Id { get; set; }

        public int IdContribuyente { get; set; }

        public string rncCedula { get; set; }
        public string NCF { get; set; }
        public decimal monto { get; set; }
        public decimal itbis18 { get; set; }

    }

}
