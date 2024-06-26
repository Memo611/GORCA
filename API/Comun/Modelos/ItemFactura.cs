using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.JavaScript;

namespace API.Comun;

public class ItemFactura
{
    public int Fol { get; set; }
    public int Ver { get; set; }
    public string MetPago { get; set; }
    public string NumCer { get; set; }
    public string ForPago { get; set; }
    public DateTime FecEmi { get; set; }
    public TimeSpan HoraEmi { get; set; }
    [Column(TypeName="money")]
    public decimal Subt { get; set; }
    public decimal IVA { get; set; }
    [Column(TypeName="money")]
    public decimal Tot { get; set; }
    public int ID_Cli { get; set; }
    public int ID_Gorca { get; set; }
    public bool Habilitado { get; set; }
}