using tpmodul4_1302223134;

KodePos objKodePos = new KodePos();
Console.WriteLine("Kode pos Batununggal adalah " + objKodePos.getKodePos(KodePos.enumKelurahan.Batununggal));

DoorMachine objDoorMachine = new DoorMachine();
Console.WriteLine("\nKeadaan pintu: " + objDoorMachine.currentState);
Console.WriteLine("Menggunakan trigger BukaPintu");
objDoorMachine.ActivateTrigger(Trigger.BukaPintu);