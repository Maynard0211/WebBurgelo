using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebBurgelo.Models;

[Table("Delivery")]
public class DeliveryModel
{
    [Key]
    [Column("DeliveryId")]
    public int DeliveryId { set; get; }
    [Column("DeliveryCode")]
    public string DeliveryCode { set; get; }
    [Column("ShipperId")]
    public int ShipperId { set; get; } = 0;
    // 0 - Waiting, 1 - Delivering, 2 - Success, 3 - Fail
    [Column("DeliveryStatus")]
    public int DeliveryStatus { set; get; } = 0;
    [Column("CustomerConfirm")]
    // 0 - Waiting, 1 - Receive,
    public int CustomerConfirm { set; get; }
}