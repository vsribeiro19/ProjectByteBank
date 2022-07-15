using byteBank;
Console.WriteLine("Seja bem-vindo ao ByteBank");
Console.WriteLine();
ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Victor";
conta1.conta = "12305";
conta1.numeroAgencia = 253;
conta1.nomeAgencia = "Banco Central";
conta1.saldo = 35.000;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "José";
conta2.conta = "33062";
conta2.numeroAgencia = 50;
conta2.nomeAgencia = "Santander";
conta2.saldo = 1.350;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Nº Agência: " + conta1.numeroAgencia);
Console.WriteLine("Nome Agência: " + conta1.nomeAgencia);
Console.WriteLine("Saldo atual: " + conta1.saldo);
Console.WriteLine();
Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Nº Agência: " + conta2.numeroAgencia);
Console.WriteLine("Nome Agência: " + conta2.nomeAgencia);
Console.WriteLine("Saldo atual: " + conta2.saldo);

//Console.ReadKey(); //aguarda esperar alguma tecla para finalizar

