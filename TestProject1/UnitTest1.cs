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
        //TC-1.1
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {

            totalRecord = censusAnalyser.LoadCensusData(indianStateCensusFilePath, Country.INDIA, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }
        //TC-1.2
        [Test]
        public void GivenWrongIndianCensusDataFile_WhenReaded_ShouldReturnCustomException()
        {

            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(wrongIndianStateCensusFilePath, Country.INDIA, indianStateCensusHeaders));

            Assert.AreEqual(CensusAnalyserException.ExceptionType.FILE_NOT_FOUND, censusException.eType);

        }
        //TC-1.3
        [Test]
        public void GiventheStateCensusCSVFilewhencorrectbuttypeincorrectReturnsacustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(wrongIndianStateCodeFileType, Country.INDIA, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE, censusException.eType);
        }
        //TC-1.4
        [Test]

        public void GiventheStateCensusCSVFilewhencorrectbutDelimeterincorrectReturnsacustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(delimiterIndianCensusFilePath, Country.INDIA, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_DELIMITER, censusException.eType);
        }
        //TC-1.5
        [Test]

        public void GiventheStateCensusCSVFilewhencorrectbuHeaderincorrectReturnsacustomException()
        {
            var censusException = Assert.Throws<CensusAnalyserException>(() => censusAnalyser.LoadCensusData(wrongHeaderIndianCensusFilePath, Country.INDIA, indianStateCensusHeaders));
            Assert.AreEqual(CensusAnalyserException.ExceptionType.INCORRECT_HEADER, censusException.eType);
        }
    }


}