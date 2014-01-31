using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorGadgetGui.ProcessCommunication;

namespace InspectorGadgetGui
{


    class Utils
    {

        public static string toAscii(string input)
        {
            string retVal = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                string currChar = input.Substring(i, 2);
                retVal = retVal + (Convert.ToChar(Convert.ToUInt32(currChar, 16)));
            }


            return retVal;
        }

        public static executionState readExecutionState()
        {
            executionState readExecutionState = new executionState();

            String disAssemblyLine = ProcessCommunicator.readLine();


            if (disAssemblyLine.Trim() == "" || disAssemblyLine == "error")
            {
                throw new Exception("Execution resulted in error");

            }
            else if (disAssemblyLine == "DISASSEMBLY:")
            {
                disAssemblyLine = "";
                String currDisAssemblyLine = ProcessCommunicator.readLine();
                while (true)
                {
                    disAssemblyLine = disAssemblyLine + currDisAssemblyLine + "\r\n";
                    currDisAssemblyLine = ProcessCommunicator.readLine();
                    if (currDisAssemblyLine == "Disassembly end") break;
                }

            }

            readExecutionState.disassembly = disAssemblyLine;

            String registersLine = ProcessCommunicator.readLine();


            foreach (String registerAndValue in registersLine.Split('\t'))
            {
                String registerName = registerAndValue.Split(':')[0];
                String registerValue = registerAndValue.Split(':')[1];

                String[] registerValueSplitted = registerValue.Split('-');

                if (registerValue.IndexOf("-") != -1)
                {
                    String commentValue = registerValueSplitted[1];
                    registerValue = registerValueSplitted[0];
                    String CPIndex = Utils.HexString2Ascii(registerValueSplitted[2]);

                    commentValue = Utils.HexString2Ascii(commentValue);

                    readExecutionState.SetPropertyAsString(registerName + "CPInfo", CPIndex);
                    readExecutionState.SetPropertyAsString(registerName + "Comment", commentValue);

                }
                readExecutionState.SetPropertyAsString(registerName, registerValue);
            }

            String eflagsLine = ProcessCommunicator.readLine();

            foreach (String registerAndValue in eflagsLine.Split('\t'))
            {
                String registerName = registerAndValue.Split(':')[0];
                String registerValue = registerAndValue.Split(':')[1];

                readExecutionState.SetPropertyAsString(registerName, registerValue != "0");
            }


            String stackStartLine = ProcessCommunicator.readLine();
            readExecutionState.stackStart = stackStartLine.Substring(12);

            String stack = "";

            while (true)
            {
                String currentStackLine = ProcessCommunicator.readLine();
                stack = stack + currentStackLine + "\t";

                if (currentStackLine == "Stack end") break;
            }
            readExecutionState.stack = stack;

            return readExecutionState;
        }


        public static string[] registers = new String[] {
            "EAX",
            "ECX",
            "EDX",
            "EBX",
            "ESP",
            "EBP",
            "ESI",
            "EDI"
      };


        public static string endianSwitch(string input)
        {

            string result = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                string hs = input.Substring(i, 2);
                result = result + Utils.Reverse(hs);

            }
            return Utils.Reverse(result);

        }

        public static bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }

        public static string fillWithZeroes(string input)
        {
            while (input.Length < 8)
            {
                input = "0" + input;
            }
            return input;
        }
        public static string HexString2Ascii(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 2; i += 2)
            {
                try
                {
                    if (hexString.Substring(i, 2) != "00")
                        sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
                }
                catch (Exception)
                {
                    return sb.ToString();
                }
            }
            return sb.ToString();
        }

        public static string HexToUnicode(string hexInput)
        {
            string inputAsUnicode = "";

            int numberChars = hexInput.Length;
            if (numberChars == 0) return "";

            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                try
                {
                    bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
                }
                catch (Exception)
                {
                    return System.Text.Encoding.Unicode.GetString(bytes);
                }
            }
            inputAsUnicode = System.Text.Encoding.Unicode.GetString(bytes);

            return inputAsUnicode;
        }

        public static String ToHex(String data)
        {
            String output = String.Empty;
            foreach (Char c in data)
            {
                output += ((int)c).ToString("X");
            }
            return output;
        }

        public static bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return test.All(c => "0123456789abcdefABCDEF\n".Contains(c));

        }

        public static long GetTime()
        {
            DateTime dtCurTime = DateTime.Now.ToUniversalTime();

            DateTime dtEpochStartTime = Convert.ToDateTime("1/1/1970 0:00:00 AM");

            TimeSpan ts = dtCurTime.Subtract(dtEpochStartTime);

            double epochtime;

            epochtime = ((((((ts.Days * 24) + ts.Hours) * 60) + ts.Minutes) * 60) + ts.Seconds);

            return Convert.ToInt64(epochtime);
        }

        public static string getCyclicPattern(int from, int to)
        {
            string char1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string char2 = "abcdefghijklmnopqrstuvwxyz";
            string char3 = "0123456789";

            string retVal = "";
            int counter = -1;
            foreach (char currChar1 in char1)
            {
                foreach (char currChar2 in char2)
                {
                    foreach (char currChar3 in char3)
                    {
                        ++counter; if ((counter >= from) && (counter <= to)) retVal += currChar1;
                        ++counter; if ((counter >= from) && (counter <= to)) retVal += currChar2;
                        ++counter; if ((counter >= from) && (counter <= to)) retVal += currChar3;
                    }
                }
            }
            return retVal;
        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }



    public interface MPropertyAsStringSettable { }
    public static class PropertyAsStringSettable
    {
        public static void SetPropertyAsString(
          this MPropertyAsStringSettable self, string propertyName, string value)
        {
            var property = TypeDescriptor.GetProperties(self)[propertyName];
            var convertedValue = property.Converter.ConvertFrom(value);
            property.SetValue(self, convertedValue);
        }
        public static void SetPropertyAsString(
          this MPropertyAsStringSettable self, string propertyName, bool value)
        {
            var property = TypeDescriptor.GetProperties(self)[propertyName];
            var convertedValue = value;
            property.SetValue(self, convertedValue);
        }
    }

    public class executionState : MPropertyAsStringSettable
    {
        public String EAX { get; set; }        public String EAXComment { get; set; }   public String EAXCPInfo { get; set; }
        public String ECX { get; set; }        public String ECXComment { get; set; }   public String ECXCPInfo { get; set; }
        public String EDX { get; set; }        public String EDXComment { get; set; }   public String EDXCPInfo { get; set; }
        public String EBX { get; set; }        public String EBXComment { get; set; }   public String EBXCPInfo { get; set; }
        public String ESP { get; set; }        public String ESPComment { get; set; }   public String ESPCPInfo { get; set; }
        public String EBP { get; set; }        public String EBPComment { get; set; }   public String EBPCPInfo { get; set; }
        public String ESI { get; set; }        public String ESIComment { get; set; }   public String ESICPInfo { get; set; }
        public String EDI { get; set; }        public String EDIComment { get; set; }   public String EDICPInfo { get; set; }
        public String EIP { get; set; }        public String EIPComment { get; set; }   public String EIPCPInfo { get; set; }

        public bool C { get; set; }
        public bool P { get; set; }
        public bool A { get; set; }
        public bool Z { get; set; }
        public bool S { get; set; }
        public bool T { get; set; }
        public bool O { get; set; }

        public String disassembly { get; set; }
        public String stackStart { get; set; }
        public String stack { get; set; }


    }
}
