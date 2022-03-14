using CodingTest.SA.Analytics.WebAPI.Data.Models;
using CodingTest.SA.Analytics.WebAPI.Mappings.CsvHelper;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace CodingTest.SA.Analytics.WebAPI.Extensions
{
    public class FileExtension
    {
        public static List<ModelResults> GetCSVData(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) throw new ArgumentNullException($"filePath is null");
            using TextReader reader = new StreamReader(filepath, Encoding.Default);
            var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
            csvReader.Context.RegisterClassMap<ModelResultsMap>();
            var result = csvReader.GetRecords<ModelResults>();
            return result.ToList();
        }
    }
}
