using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTFSTools.IO
{
    public static class Extensions
    {
        public static void ReadCSV(this System.Data.DataTable datatable, System.IO.Stream stream)
        {
            Console.Write("table = {0}", datatable.TableName);
            datatable.BeginLoadData();
            using (var parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(stream))
            {
                parser.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                parser.Delimiters = new String[] { "," };
                parser.TrimWhiteSpace = true;
                var header = parser.ReadFields();
                var headerIndex = header.Select((name, ordinal) => new { name, ordinal }).ToDictionary(key => key.name, element => element.ordinal);
                while (!parser.EndOfData)
                {
                    var data = parser.ReadFields();
                    var newRow = datatable.NewRow();
                    for (var index = 0; index < datatable.Columns.Count; index++)
                    {
                        var column = datatable.Columns[index];
                        if (headerIndex.ContainsKey(column.ColumnName))
                        {
                            var dataString = data[headerIndex[column.ColumnName]];
                            switch (column.DataType.Name)
                            {
                                case "Boolean":
                                    newRow[index] = dataString == "1";
                                    break;
                                case "DateTime":
                                    {
                                        DateTime value = new DateTime();
                                        if (Microsoft.VisualBasic.Information.IsNumeric(dataString) && dataString.Length == 8)
                                            dataString = dataString.Substring(0, 4) + "-" + dataString.Substring(4, 2)+ "-" + dataString.Substring(6, 2);
                                        if (DateTime.TryParse(dataString, out value))
                                            newRow[index] = value;
                                    }
                                    break;
                                case "Decimal":
                                    {
                                        Decimal value = 0;
                                        if (Decimal.TryParse(dataString, out value))
                                            newRow[index] = value;
                                    }
                                    break;
                                case "Double":
                                    {
                                        Double value = 0;
                                        if (Double.TryParse(dataString, out value))
                                            newRow[index] = value;
                                    }
                                    break;
                                case "Int32":
                                    {
                                        Int32 value = 0;
                                        if (Int32.TryParse(dataString, out value))
                                            newRow[index] = value;
                                    }
                                    break;
                                case "String":
                                    newRow[index] = dataString;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    datatable.Rows.Add(newRow);
                }
            }
            datatable.EndLoadData();
            Console.WriteLine("\trows = {0}", datatable.Rows.Count);
        }
    }
}
