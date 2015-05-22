using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GTFSTools.IO
{
    public static class Extensions
    {
        public static void ReadCSV(this System.Data.DataTable datatable, System.IO.Stream stream)
        {
            var timeSpanExpression = new Regex("^([0-9]{2}):([0-9]{2}):([0-9]{2})");
            Console.Write("table = {0}", datatable.TableName);
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
                                case "TimeSpan":
                                    {
                                        var match = timeSpanExpression.Match(dataString);
                                        if (match.Success)
                                        {
                                            newRow[index] = new TimeSpan(Convert.ToInt32(match.Groups[1].Value), Convert.ToInt32(match.Groups[2].Value), Convert.ToInt32(match.Groups[3].Value));
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    datatable.Rows.Add(newRow);
                }
            }
            Console.WriteLine("\trows = {0}", datatable.Rows.Count);
        }
        public static void WriteCSV(this System.Data.DataTable datatable, System.IO.Stream stream)
        {
            Console.Write("table = {0}", datatable.TableName);
            using (var writer = new System.IO.StreamWriter(stream))
            {
                var header = String.Join(",",datatable.Columns.OfType<System.Data.DataColumn>().Select(item=>item.ColumnName));
                writer.WriteLine(header);
                foreach (System.Data.DataRow row in datatable.Rows)
                {
                    var buffer = new String[datatable.Columns.Count];
                    for (var index = 0; index < datatable.Columns.Count; index++)
                    {
                        var column = datatable.Columns[index];
                        if (!row.IsNull(index))
                        {
                            switch (column.DataType.Name)
                            {
                                case "Boolean":
                                    buffer[index] = (Boolean)row[index] ? "1" : "0";
                                    break;
                                case "DateTime":
                                    buffer[index] = String.Format("{0:yyyyMMdd}", row[index]);
                                    break;
                                case "Decimal":
                                    buffer[index] = String.Format("{0:0.0000000}", row[index]);
                                    break;
                                case "Double":
                                    buffer[index] = String.Format("{0}", row[index]);
                                    break;
                                case "Int32":
                                    buffer[index] = String.Format("{0}", row[index]);
                                    break;
                                case "String":
                                    buffer[index] = (String)row[index];
                                    break;
                                case "TimeSpan":
                                    {
                                        var value = (TimeSpan)row[index];
                                        var hours = Convert.ToInt32(Math.Floor(value.TotalHours));
                                        var minutes = value.Minutes;
                                        var seconds = value.Seconds;
                                        buffer[index] = String.Format("{0,2:D2}:{1,2:D2}:{2,2:D2}", hours, minutes, seconds);
                                    }
                                    break;
                                default:
                                    break;
                            }
                            if (buffer[index].Contains(',') || buffer[index].Contains('"'))
                            {
                                if (buffer[index].Contains('"'))
                                    buffer[index] = buffer[index].Replace("\"", "\"\"");
                                buffer[index] = "\"" + buffer[index] + "\"";
                            }
                        }
                        else
                            buffer[index] = String.Empty;
                    }
                    writer.WriteLine(String.Join(",", buffer));
                }
            }
            Console.WriteLine("\trows = {0}", datatable.Rows.Count);
        }
    }
}
