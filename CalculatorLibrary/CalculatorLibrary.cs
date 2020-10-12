using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorLibrary
{
    public class Calculator
    {
        JsonWriter writer;

        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }

        public double DoOperation(double digit1, double digit2, string operation)
        {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(digit1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(digit2);
            writer.WritePropertyName("Operation");

            switch (operation)
            {
                case "a":
                    result = digit1 + digit2;
                    writer.WriteValue("Add");
                    break;
                case "s":
                    result = digit1 - digit2;
                    writer.WriteValue("Subtract");
                    break;
                case "m":
                    result = digit1 * digit2;
                    writer.WriteValue("Multiply");
                    break;
                case "d":
                    if (digit2 != 0)
                    {
                        result = digit1 / digit2;
                        writer.WriteValue("Divide");
                    }
                    break;
                default:
                    break;
            }

            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();

            return result;
        }
        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }



    }


}
