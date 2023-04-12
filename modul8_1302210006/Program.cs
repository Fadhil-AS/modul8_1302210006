// See https://aka.ms/new-console-template for more information
using modul8_1302210006;
using System.Collections.Generic;
using System.Numerics;

BankTransferConfig_1302210006 bTfCon = new BankTransferConfig_1302210006();
int biaya;

if (bTfCon.bankTf.lang == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer: ");
    int jumlah = Convert.ToInt32(Console.ReadLine());
    if (jumlah <= bTfCon.bankTf.transfer.threshold)
    {
        biaya = bTfCon.bankTf.transfer.low_fee;
    }
    else {
        biaya = bTfCon.bankTf.transfer.high_fee;
    }

    int ress = jumlah + biaya;

    Console.WriteLine("Transfer fee = " + biaya);
    Console.WriteLine("Total amount = " + ress);

    Console.WriteLine("Select transfer method: ");

    for (int i = 0; i < bTfCon.bankTf.methods.Count; i++)
    {
        Console.WriteLine((i + 1) + ". " + bTfCon.bankTf.methods[i]);
    }

    Console.WriteLine("Please type " + bTfCon.bankTf.confirmation.en + "to confirm the transaction: ");
    String confirm = Console.ReadLine();

    if (confirm == bTfCon.bankTf.confirmation.en)
    {
        Console.WriteLine("The transfer is completed");
    }
    else {
        Console.WriteLine("Transfer is cancelled");
    }
}
else if (bTfCon.bankTf.lang == "id") {
    Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
    int jumlah = Convert.ToInt32(Console.ReadLine());
    if (jumlah <= bTfCon.bankTf.transfer.threshold)
    {
        biaya = bTfCon.bankTf.transfer.low_fee;
    }
    else
    {
        biaya = bTfCon.bankTf.transfer.high_fee;
    }

    int ress = jumlah + biaya;

    Console.WriteLine("Biaya transfer = " + biaya);
    Console.WriteLine("Total biaya = " + ress);
    Console.WriteLine("Pilih metode transfer: ");

    for (int i = 0; i < bTfCon.bankTf.methods.Count; i++) { 
        Console.WriteLine((i + 1) + ". " + bTfCon.bankTf.methods[i]);
    }

    Console.WriteLine("Ketik " + bTfCon.bankTf.confirmation.id + "untuk mengkonfirmasi transaksi: ");
    String confirm = Console.ReadLine();

    if (confirm == bTfCon.bankTf.confirmation.id)
    {
        Console.WriteLine("Proses transfer berhasil");
    }
    else
    {
        Console.WriteLine("Transfer dibatalkan");
    }
}
