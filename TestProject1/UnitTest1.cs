using IndianStateCenusAnalyser;
using IndianStateCenusAnalyser.DTO;
using NUnit.Framework;
using System.Collections.Generic;
using static IndianStateCenusAnalyser.CensusAnalyser;

namespace TestProject1
{

    public class Tests
    {

        //CensusAnalyser.CensusAnalyser censusAnalyser;

        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\WrongIndiaStateCensusData.csv";
        static string delimiterIndianCensusFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\DelimiterIndiaStateCensusData.csv";
        static string wrongIndianStateCensusFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\WrongIndiaStateCensusData1.csv";
        static string wrongIndianStateCodeHeaderFileType = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\WrongIndiaStateCode.csv";
        static string indianStateCodeFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\IndiaStateCode.csv";
        static string wrongIndianStateCodeFileType = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\IndiaStateCode.txt";
        static string delimiterIndianStateCodeFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\DelimiterIndiaStateCode.csv";
        static string wrongHeaderStateCodeFilePath = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\WrongIndiaStateCode.csv1";
        static string wrongUSCensusFileType = @"C:\Users\User\source\repos\IndianStateCenusAnalyser\TestProject1\CsvFiles\IndiaStateCode.txt";
        

        CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

    }


}