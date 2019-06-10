using DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccees;
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAcceess)
        {
            _logger = logger;
            _dataAccees = dataAcceess;
        }
        public void ProcessData()
        {
            _logger.Log("Starting  the processing of data.");
            Console.WriteLine("Processing the data");
            Console.WriteLine("");
            Console.WriteLine("");
            _dataAccees.LoadData();
            _dataAccees.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }
    }
}
