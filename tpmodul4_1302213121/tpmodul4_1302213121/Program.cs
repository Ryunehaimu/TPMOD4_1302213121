internal class Program
{
    public enum Kelurahan_1302213121
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    };
    public class KodePos_1302213121
    {
        public static int getKodePos_1302213121(Kelurahan_1302213121 kelurahan)
        {
            int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodePos[(int)kelurahan];
        }
    }
    public enum statePintu
    {
        Terkunci,
        Terbuka
    }

    public enum Trigger
    {
        kunciPintu,
        bukaPintu
    }
    public class DoorMachine_1302213121
    {
        private statePintu currentStat = statePintu.Terkunci;

        public class Transition_1302213121
        {
            public statePintu statAwal;
            public statePintu statAkhir;
            public Trigger trigger;

            public Transition_1302213121(statePintu statAwal, statePintu statAkhir, Trigger trigger)
            {
                this.statAwal = statAwal;
                this.statAkhir = statAkhir;
                this.trigger = trigger;
            }
        }

        Transition_1302213121[] transitions = new Transition_1302213121[]
        {
                new Transition_1302213121(statePintu.Terkunci, statePintu.Terkunci, Trigger.kunciPintu),
                new Transition_1302213121(statePintu.Terkunci, statePintu.Terbuka, Trigger.bukaPintu),
                new Transition_1302213121(statePintu.Terbuka, statePintu.Terbuka, Trigger.bukaPintu),
                new Transition_1302213121(statePintu.Terbuka, statePintu.Terkunci, Trigger.kunciPintu)
        };

        private statePintu GetNextStat_1302213121(statePintu statAwal, Trigger trigger)
        {
            statePintu statAkhir = statAwal;
            for (int i = 0; i < transitions.Length; i++)
            {
                Transition_1302213121 update = transitions[i];

                if (statAwal == update.statAwal && trigger == update.trigger)
                {
                    statAkhir = update.statAkhir;
                }
            }
            return statAkhir;
        }

        public void activateTrigger_1302213121(Trigger trigger)
        {
            currentStat = GetNextStat_1302213121(currentStat, trigger);
            Console.WriteLine(currentStat);

            if (currentStat == statePintu.Terkunci)
            {
                Console.WriteLine("Pintu Terkunci");
            }
            else
            {
                Console.WriteLine("Pintu Terbuka");
            }
        }
    }
    static void Main(string[] args)
    {
        Kelurahan_1302213121 kelurahan = Kelurahan_1302213121.Batununggal;
        int kodePos = KodePos_1302213121.getKodePos_1302213121(kelurahan);
        Console.WriteLine("Kelurahan: " + kelurahan + "\nKode pos: " + kodePos);

        DoorMachine_1302213121 pintu = new DoorMachine_1302213121();
        Console.WriteLine();
        pintu.activateTrigger_1302213121(Trigger.bukaPintu);
        pintu.activateTrigger_1302213121(Trigger.kunciPintu);
        pintu.activateTrigger_1302213121(Trigger.kunciPintu);
    }
}
