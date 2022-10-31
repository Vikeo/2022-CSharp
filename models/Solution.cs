using System.Collections.Generic;
using System.Drawing;

namespace DotNet.models
{
    public class Solution
    {
        public bool RecycleRefundChoice { get; set; }
        public int BagPrice { get; set; }
        public int RefundAmount { get; set; }
        public int BagType { get; set; }
        public List<int> Orders { get; set; }

        public Solution(bool recycleRefundChoice, int bagPrice, int refundAmount, int bagType, List<int> orders)
        {
            RecycleRefundChoice = recycleRefundChoice;
            bagPrice = bagPrice;
            RefundAmount = refundAmount;
            BagType = bagType;
            Orders = orders;
        }
    }
}