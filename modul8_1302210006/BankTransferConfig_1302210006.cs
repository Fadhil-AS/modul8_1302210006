using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302210006
{
    internal class BankTransferConfig_1302210006
    {
        public bankTransfer_1302210006 bankTf;
        public const string bFile = @"bank_transfer_config.json";

        public BankTransferConfig_1302210006() {
            try
            {
                ReadConfigFile_1302210006();
                Console.WriteLine("Membaca config file JSON");
            }
            catch (Exception)
            {
                Console.WriteLine("Membuat config file default");
                setDefault_1302210006();
                WriteConfigFile_1302210006();
            }
        }

        public void ReadConfigFile_1302210006() { 
            string jsontxt = File.ReadAllText(bFile);
            bankTf = JsonSerializer.Deserialize<bankTransfer_1302210006>(jsontxt);
        }

        public void WriteConfigFile_1302210006()
        {
            JsonSerializerOptions opt = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            String jsonText = JsonSerializer.Serialize(bankTf, opt);
            File.WriteAllText(bFile, jsonText);
        }

        public void setDefault_1302210006() { 
            bankTf = new bankTransfer_1302210006();
            bankTf.lang = "en";
            bankTf.transfer.threshold = 25000000;
            bankTf.transfer.low_fee = 6500;
            bankTf.transfer.high_fee = 15000;
            //List<string> methods = new List<string>();
            bankTf.methods.Add("RTO (real-time)");
            bankTf.methods.Add("SKN");
            bankTf.methods.Add("RTGS");
            bankTf.methods.Add("BI FAST");
            bankTf.confirmation.en = "yes";
            bankTf.confirmation.id = "ya";
        }

    }

    public class bankTransfer_1302210006 {
        public string lang { set; get; }
        public Transfer_1302210006 transfer { set; get; }
        public List<string> methods { set; get; }
        public Confirmation_1302210006 confirmation { set; get; }
        public bankTransfer_1302210006() { }
        public bankTransfer_1302210006(string lang, Transfer_1302210006 transfer, List<string> methods, Confirmation_1302210006 confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }

    public class Transfer_1302210006 {
        public int threshold;
        public int low_fee;
        public int high_fee;

        public Transfer_1302210006() { }
        public Transfer_1302210006(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }

    public class Confirmation_1302210006 { 
        public string en { set; get; }
        public string id { set; get; }

        public Confirmation_1302210006() { }

        public Confirmation_1302210006(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }
}
