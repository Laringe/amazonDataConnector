using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AmazonDataConnector.Models
{
    public class AcuOrder
    {
        public int Id { get; set; }
        public string FullAcuOrderId;
        private string amzOrderId;

        public string GetAmzOrderId()
        {
            return amzOrderId;
        }

        public void SetAmzOrderId(string value)
        {
            amzOrderId = value;
        }

        public string AmzOrderList { get; set; }

        public string[] GetAmzOrdersArray()
        {
            return amzOrdersArray;
        }

        public void SetAmzOrdersArray(string[] value)
        {
            amzOrdersArray = value;
        }

        private string[] amzOrdersArray;
        public AcuOrder()
        {

        }
    }
}