using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedata
{
    public enum PokeType
    {
        BUG, DRAGON, FAIRY, FIRE, GHOST, GROUND,
        NORMAL, PSYCHIC, STEEL, DARK, ELECTRIC, FIGHTING,
        FLYING, GRASS, ICE, POISON, ROCK, WATER,
        NONE, CORRUPTED, BIRD
    }


    public enum EvolveTask
    { LEVEL_UP, TRADE, USE_ITEM, EEVEE_LUTION }

    public class EvolveAction
    {
        public EvolveTask Task { get; }
        public string ExtraTask { get; }

        public EvolveAction(EvolveTask task, string extraTask = "")
        {
            Task = task;
            ExtraTask = extraTask;
        }
    }

    public class Stats
    {
        public byte HP { get; }
        public byte Attack { get; }
        public byte Defense { get; }
        public byte SpecialAttack { get; }
        public byte SpecialDefense { get; }
        public byte Speed { get; }

        public Stats(byte hp, byte attack, byte defense, byte spAttack, byte spDefense, byte speed)
        {
            HP = (byte)(hp == 0 ? 1 : hp);
            Attack = (byte)(attack == 0 ? 1 : attack);
            Defense = (byte)(defense == 0 ? 1 : defense);
            SpecialAttack = (byte)(spAttack == 0 ? 1 : spAttack);
            SpecialDefense = (byte)(spDefense == 0 ? 1 : spDefense);
            Speed = (byte)(speed == 0 ? 1 : speed);
        }
    }

    public class GenderRatio
    {
        public double Male { get; }
        public double Female { get; }

        public GenderRatio(double male, double female)
        {
            Male = (int)(Math.Abs(male - (int)male) * 100) / 100.0;
            Female = (int)(Math.Abs(female - (int)female) * 100) / 100.0;
        }
    }
}
