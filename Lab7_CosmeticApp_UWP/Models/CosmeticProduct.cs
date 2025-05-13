using System;

namespace Lab7_CosmeticApp_UWP.Models
{
    public class CosmeticProduct
    {
        public int CosmeticProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsAvailable { get; set; }
    }
}