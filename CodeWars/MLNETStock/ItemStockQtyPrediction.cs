using Microsoft.ML.Data;

namespace MLNETStock
{
    public class ItemStockQtyPrediction
    {
        [ColumnName("Score")]
        public float TotalStockQty;
    }
}