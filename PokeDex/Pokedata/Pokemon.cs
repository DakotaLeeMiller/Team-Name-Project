using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedata
{
    public class Pokemon
    {
        public string ImageSource { get; private set; }
        public string CrySoundSource { get; private set; }
        public ushort DexNumber { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public PokeType Type1 { get; private set; }
        public PokeType Type2 { get; private set; }
        public List<Ability> Abilities { get; private set; }
        public Stats BaseStats { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public GenderRatio GenderRatio { get; private set; }
        public Pokemon EvolveFrom { get; set; }
        public EvolveAction EvolveFromAction { get; set; }
        public Pokemon EvolveTo { get; set; }
        public EvolveAction EvolveToAction { get; set; }
        public bool? IsLegendary { get; private set; }
        
        public Pokemon() { }
        public Pokemon(ushort dexNumber, string name, string description, string category, PokeType type1, PokeType type2, List<Ability> abilities, Stats baseStats, double height, double weight, GenderRatio genderRatio, string evolveToName, EvolveAction evolveToAction, bool isLegendary = false)
        {
            DexNumber = dexNumber;
            Name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            Description = description;
            Category = category.ToUpper();
            Type1 = type1;
            Type2 = type2;
            Abilities = abilities;
            BaseStats = baseStats;
            Height = (int)(height * 100) / 100.0;
            Weight = (int)(weight * 100) / 100.0;
            GenderRatio = genderRatio;
            IsLegendary = isLegendary;

            if (evolveToName != "")
            {
                EvolveTo = new Pokemon(0,evolveToName,"","",PokeType.NONE,PokeType.NONE,null,null,0,0,null,"",null,false);
                EvolveToAction = evolveToAction;
                EvolveTo.EvolveFrom = this;
                EvolveTo.EvolveFromAction = this.EvolveToAction;
            }
            
            ImageSource = "ms-appx:///Assets/Gen I Pics/" + DexNumber.ToString("000") + Name + ".png";
            CrySoundSource = "ms-appx:///Assets/Cry Sounds/" + DexNumber.ToString("000") + ".wav";
        }

        public string GetTypePictureSource(int typeNum)
        {
            if (typeNum < 1 || typeNum > 2) throw new IndexOutOfRangeException("You can only select either type 1 or type 2");

            PokeType type = typeNum == 1 ? Type1 : Type2;

            return "ms-appx:///Assets/Types/" + type.ToString().Substring(0, 1).ToUpper() + type.ToString().Substring(1).ToLower() + ".png";
        }
    }
}
