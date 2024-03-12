namespace tpmodul4_1302223134;
public enum DoorState
{
    Terkunci, Terbuka
}
public enum Trigger
{
    KunciPintu, BukaPintu
}

internal class DoorMachine
{
    public class Transition
    {
        public DoorState stateAwal;
        public DoorState stateAkhir;
        public Trigger trigger;

        public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.trigger = trigger;
        }
    }

    Transition[] transisi =
    {
        new Transition(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu),
        new Transition(DoorState.Terkunci, DoorState.Terkunci, Trigger.KunciPintu),
        new Transition(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu),
        new Transition(DoorState.Terbuka, DoorState.Terbuka, Trigger.BukaPintu)
    };

    public DoorState currentState = DoorState.Terkunci;

    public DoorState getNextState(DoorState stateAwal, Trigger trigger)
    {
        DoorState stateAkhir = stateAwal;
        foreach (var t in transisi)
        {
            Transition perubahan = t;
            if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
            {
                stateAkhir = perubahan.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void ActivateTrigger(Trigger trigger)
    {
        currentState = getNextState(currentState, trigger);

        Console.WriteLine(currentState == DoorState.Terkunci ? "Pintu terkunci" : "Pintu terbuka");
    }

}
