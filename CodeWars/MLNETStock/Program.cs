using System;
using System.IO;
using System.Threading.Tasks;

namespace MLNETStock
{
    internal class Program
    {
        private static readonly string _Traindatapath = Path.Combine(Environment.CurrentDirectory, "Data", "StockTrain.csv");
        private static readonly string _Evaluatedatapath = Path.Combine(Environment.CurrentDirectory, "Data", "StockTest.csv");
        private static readonly string _modelpath = Path.Combine(Environment.CurrentDirectory, "Data", "Model.zip");

        private static async Task Main(string[] args)
        {
            PredictionModel<ItemStock, ItemStockQtyPrediction> model = await TrainOurModel();
        }

        public static async Task<PredictionModel<ItemStock, ItemStockQtyPrediction>> TrainOurModel()
        {
        }
    }
}