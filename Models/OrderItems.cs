using FikaAmazonAPI;

namespace AmazonDataConnector.Models {
    public class OrderItems {
        public string AmzOrderId {
            get; set;
        }
        private object Items;
        AmazonConnection amazonConnection;
        public OrderItems(AmazonConnection amazonConnection) {
            this.amazonConnection = amazonConnection;
        }
        public OrderItems(string amzOrderId, AmazonConnection amazonConnection) {
            AmzOrderId = amzOrderId;
            this.GetOrderItems();
            this.amazonConnection = amazonConnection;
        }
        public void GetOrderItems() {
            Items = amazonConnection.Orders.GetOrderItems(AmzOrderId);
        }
    }
}