using bytebank;

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Maria";
conta1.agencia = "1310-x";
conta1.saldo = 300;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Agencia: " + conta1.agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("saldo antes de sacar: " + conta1.saldo);
conta1.sacar(50);
Console.WriteLine("saldo atual: " + conta1.saldo);
