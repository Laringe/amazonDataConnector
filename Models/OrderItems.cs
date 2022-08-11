using FikaAmazonAPI;

namespace AmazonDataConnector.Models {
    public class OrderItems {
        public string AmzOrderId {
            get; set;
        }
        private object Details;
        AmazonConnection amazonConnection;
        public OrderItems(AmazonConnection amazonConnection) {
            this.amazonConnection = amazonConnection;
        }
        public object GetDetails() {
            return Details;
        }
        public void GetOrderItems() {
            var Items = amazonConnection.Orders.GetOrderItems(AmzOrderId);
        }
    }
}