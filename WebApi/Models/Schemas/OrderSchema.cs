namespace WebApi.Models.Schemas
{
    public class OrderSchema
    {
        public int PaymentDetailId { get; set; }
        public int AddressId { get; set; }

        public int PromoCodeId { get; set; }    

        public Dictionary<int,int> ProductIds { get; set; }
    }
}
