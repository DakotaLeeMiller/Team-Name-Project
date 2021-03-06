﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedata
{
    public class Ability
    {
        public string Name { get; }
        public string Description { get; }

        private Ability(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public static Ability Adaptability = new Ability("Adaptability", "Powers up moves of the same type");
        public static Ability Aerilate = new Ability("Aerilate", "Turns Normal-type moves into Flying-type moves");
        public static Ability Aftermath = new Ability("Aftermath", "Damages the attacker landing the finishing hit");
        public static Ability AirLock = new Ability("Air Lock", "Eliminates the effects of weather");
        public static Ability Analytic = new Ability("Analytic", "Boosts move power when the Pokémon moves last");
        public static Ability AngerPoint = new Ability("Anger Point", "Maxes Attack after taking a critical hit");
        public static Ability Anticipation = new Ability("Anticipation", "Senses a foe's dangerous moves");
        public static Ability ArenaTrap = new  Ability("Arena Trap", "Prevents the foe from fleeing");
        public static Ability AromaVeil = new  Ability("Aroma Veil", "Protects allies from attacks that limit their move choices");
        public static Ability AuraBreak = new  Ability("Aura Break", "The effects of “Aura” Abilities are reversed");
        public static Ability BadDreams = new  Ability("Bad Dreams", "Reduces a sleeping foe's HP");
        public static Ability Battery = new Ability("Battery", "Raises power of teammates' Special moves");
        public static Ability BattleArmor = new Ability("Battle Armor", "The Pokémon is protected against critical hits");
        public static Ability BattleBond = new Ability("Battle Bond", "Transform into Ash-Greninja after causing opponent to faint");
        public static Ability BeastBoost = new Ability("Beast Boost", "The Pokémon boosts its most proficient stat each time it knocks out a Pokémon");
        public static Ability Berserk = new Ability("Berserk", "Raises Special Attack when HP drops below half");
        public static Ability BigPecks = new Ability("Big Pecks", "Protects the Pokémon from Defense-lowering attacks");
        public static Ability Blaze = new Ability("Blaze", "Powers up Fire-type moves in a pinch");
        public static Ability Bulletproof = new Ability("Bulletproof", "Protects the Pokémon from ball and bomb moves");
        public static Ability CheekPouch = new Ability("Cheek Pouch", "Restores additional HP when a Berry is consumed");
        public static Ability Chlorophyll = new Ability("Chlorophyll", "Boosts the Pokémon's Speed in sunshine");
        public static Ability ClearBody = new  Ability("Clear Body", "Prevents other Pokémon from lowering its stats");
        public static Ability CloudNine = new  Ability("Cloud Nine", "Eliminates the effects of weather");
        public static Ability ColorChange = new Ability("Color Change", "Changes the Pokémon's type to the foe's move");
        public static Ability Comatose = new Ability("Comatose", "Prevents all status conditions except Sleep");
        public static Ability Competitive = new Ability("Competitive", "Raises Special Attack when the Pokémon's stats are lowered");
        public static Ability CompoundEyes = new Ability("Compound Eyes", "The Pokémon's accuracy is boosted");
        public static Ability Contrary = new Ability("Contrary", "Makes stat changes have an opposite effect");
        public static Ability Corrosion = new Ability("Corrosion", "The Pokémon can poison Steel and Poison types");
        public static Ability CursedBody = new Ability("Cursed Body", "May disable a move used on the Pokémon");
        public static Ability CuteCharm = new  Ability("Cute Charm", "Contact with the Pokémon may cause infatuation");
        public static Ability Damp = new Ability("Damp", "Prevents the use of self-destructing moves");
        public static Ability Dancer = new Ability("Dancer", "Copies the foe's Dance moves");
        public static Ability DarkAura = new Ability("Dark Aura", "Raises power of Dark type moves for all Pokémon in battle");
        public static Ability Dazzling = new Ability("Dazzling", "Protects the Pokémon from high-priority moves");
        public static Ability Defeatist = new Ability("Defeatist", "Lowers stats when HP drops below half");
        public static Ability Defiant = new Ability("Defiant", "When its stats are lowered its Attack increases");
        public static Ability DeltaStream = new Ability("Delta Stream", "Creates strong winds when the ability activates");
        public static Ability DesolateLand = new Ability("Desolate Land", "Turns the sunlight extremely harsh when the ability activates");
        public static Ability Disguise = new Ability("Disguise", "Avoids damage for one turn");
        public static Ability Download = new Ability("Download", "Adjusts power according to a foe's defenses");
        public static Ability Drizzle = new Ability("Drizzle", "The Pokémon makes it rain when it enters a battle");
        public static Ability Drought = new Ability("Drought", "Turns the sunlight harsh when the Pokémon enters a battle");
        public static Ability DrySkin = new Ability("Dry Skin", "Reduces HP if it is hot Water restores HP");
        public static Ability EarlyBird = new  Ability("Early Bird", "The Pokémon awakens quickly from sleep");
        public static Ability EffectSpore = new Ability("Effect Spore", "Contact may poison or cause paralysis or sleep");
        public static Ability ElectricSurge = new Ability("Electric Surge", "The Pokémon creates an Electric Terrain when it enters a battle");
        public static Ability EmergencyExit = new Ability("Emergency Exit", "The Pokémon, sensing danger, switches out when its HP becomes half or less");
        public static Ability FairyAura = new  Ability("Fairy Aura", "Raises power of Fairy type moves for all Pokémon in battle");
        public static Ability Filter = new Ability("Filter", "Reduces damage from supereffective attacks");
        public static Ability FlameBody = new  Ability("Flame Body", "Contact with the Pokémon may burn the attacker");
        public static Ability FlareBoost = new Ability("Flare Boost", "Powers up special attacks when burned");
        public static Ability FlashFire = new  Ability("Flash Fire", "It powers up Fire-type moves if it's hit by one");
        public static Ability FlowerGift = new Ability("Flower Gift", "Powers up party Pokémon when it is sunny");
        public static Ability FlowerVeil = new Ability("Flower Veil", "Prevents lowering of ally Grass-type Pokémon's stats");
        public static Ability Fluffy = new Ability("Fluffy", "Reduces damage from contact moves, but doubles damage from Fire-type moves");
        public static Ability Forecast = new Ability("Forecast", "Castform transforms with the weather");
        public static Ability Forewarn = new Ability("Forewarn", "Determines what moves a foe has");
        public static Ability FriendGuard = new Ability("Friend Guard", "Reduces damage done to allies");
        public static Ability Frisk = new Ability("Frisk", "The Pokémon can check a foe's held item");
        public static Ability FullMetalBody = new Ability("Full Metal Body", "Prevents other Pokémon from lowering its stats");
        public static Ability FurCoat = new Ability("Fur Coat", "Reduces damage from physical moves");
        public static Ability GaleWings = new  Ability("Gale Wings", "Gives priority to Flying-type moves");
        public static Ability Galvanize = new Ability("Galvanize", "Normal-type moves become Electric-type moves and their power boosted");
        public static Ability Gluttony = new Ability("Gluttony", "Encourages the early use of a held Berry");
        public static Ability GooeyContact = new Ability("GooeyContact", "with the Pokémon lowers the attacker's Speed stat");
        public static Ability GrassPelt = new  Ability("Grass Pelt", "Boosts the Defense stat in Grassy Terrain");
        public static Ability GrassySurge = new Ability("Grassy Surge", "The Pokémon creates a Grassy Terrain when it enters a battle");
        public static Ability Guts = new Ability("Guts", "Boosts Attack if there is a status problem");
        public static Ability Harvest = new Ability("Harvest", "May create another Berry after one is used");
        public static Ability Healer = new Ability("Healer", "May heal an ally's status conditions");
        public static Ability Heatproof = new Ability("Heatproof", "Weakens the power of Fire-type moves");
        public static Ability HeavyMetal = new Ability("Heavy Metal", "Doubles the Pokémon's weight");
        public static Ability HoneyGather = new Ability("Honey Gather", "The Pokémon may gather Honey from somewhere");
        public static Ability HugePower = new  Ability("Huge Power", "Raises the Pokémon's Attack stat");
        public static Ability Hustle = new Ability("Hustle", "Boosts the Attack stat, but lowers accuracy");
        public static Ability Hydration = new Ability("Hydration", "Heals status problems if it is raining");
        public static Ability HyperCutter = new Ability("Hyper Cutter", "Prevents other Pokémon from lowering Attack stat");
        public static Ability IceBody = new Ability("Ice Body", "The Pokémon gradually regains HP in a hailstorm");
        public static Ability Illuminate = new Ability("Illuminate", "Raises the likelihood of meeting wild Pokémon");
        public static Ability Illusion = new Ability("Illusion", "Comes out disguised as the Pokémon in back");
        public static Ability Immunity = new Ability("Immunity", "Prevents the Pokémon from getting poisoned");
        public static Ability Imposter = new Ability("Imposter", "It transforms itself into the Pokémon it is facing");
        public static Ability Infiltrator = new Ability("Infiltrator", "Passes through the foe's barrier and strikes");
        public static Ability InnardsOut = new Ability("Innards Out", "Deals damage upon fainting");
        public static Ability InnerFocus = new Ability("Inner Focus", "The Pokémon is protected from flinching");
        public static Ability Insomnia = new Ability("Insomnia", "Prevents the Pokémon from falling asleep");
        public static Ability Intimidate = new Ability("Intimidate", "Lowers the foe's Attack stat");
        public static Ability IronBarbs = new  Ability("Iron Barbs", "Inflicts damage to the Pokémon on contact");
        public static Ability IronFist = new Ability("Iron Fist", "Boosts the power of punching moves");
        public static Ability Justified = new Ability("Justified", "Raises Attack when hit by a Dark-type move");
        public static Ability KeenEye = new Ability("Keen Eye", "Prevents other Pokémon from lowering accuracy");
        public static Ability KlutzThe = new Ability("Klutz", "The Pokémon can't use any held items");
        public static Ability LeafGuard = new  Ability("Leaf Guard", "Prevents problems with status in sunny weather");
        public static Ability Levitate = new Ability("Levitate", "Gives immunity to Ground type moves");
        public static Ability LightMetal = new Ability("Light Metal", "Halves the Pokémon's weight");
        public static Ability LightningRod = new Ability("Lightning Rod", "Draws in all Electric-type moves to up Sp Attack");
        public static Ability Limber = new Ability("Limber", "The Pokémon is protected from paralysis");
        public static Ability LiquidOoze = new Ability("Liquid Ooze", "Damages attackers using any draining move");
        public static Ability LiquidVoice = new Ability("Liquid Voice", "All sound-based moves become Water-type moves");
        public static Ability LongReach = new  Ability("Long Reach", "The Pokémon uses its moves without making contact with the target");
        public static Ability MagicBounce = new Ability("Magic Bounce", "Reflects status- changing moves");
        public static Ability MagicGuard = new Ability("Magic Guard", "The Pokémon only takes damage from attacks");
        public static Ability Magician = new Ability("Magician", "The Pokémon steals the held item of a Pokémon it hits with a move");
        public static Ability MagmaArmor = new Ability("Magma Armor", "Prevents the Pokémon from becoming frozen");
        public static Ability MagnetPull = new Ability("Magnet Pull", "Prevents Steel-type Pokémon from escaping");
        public static Ability MarvelScale = new Ability("Marvel Scale", "Ups Defense if there is a status problem");
        public static Ability MegaLauncher = new Ability("Mega Launcher", "Boosts the power of aura and pulse moves");
        public static Ability Merciless = new Ability("Merciless", "The Pokémon’s attacks become critical hits if the target is poisoned");
        public static Ability Minus = new Ability("Minus", "Ups Sp Atk if another Pokémon has Plus or Minus");
        public static Ability MistySurge = new Ability("Misty Surge", "The Pokémon creates a Misty Terrain when it enters a battle");
        public static Ability MoldBreaker = new Ability("Mold Breaker", "Moves can be used regardless of Abilities");
        public static Ability Moody = new Ability("Moody", "Raises one stat and lowers another");
        public static Ability MotorDrive = new Ability("Motor Drive", "Raises Speed if hit by an Electric-type move");
        public static Ability Moxie = new Ability("Moxie", "Boosts Attack after knocking out any Pokémon");
        public static Ability Multiscale = new Ability("Multiscale", "Reduces damage when HP is full");
        public static Ability Multitype = new Ability("Multitype", "Changes type to match the held Plate");
        public static Ability Mummy = new Ability("Mummy", "Contact with this Pokémon spreads this Ability");
        public static Ability NaturalCure = new Ability("Natural Cure", "All status problems heal when it switches out");
        public static Ability Neuroforce = new Ability("Neuroforce", "Powers up moves that are super effective");
        public static Ability NoGuard = new Ability("No Guard", "Ensures attacks by or against the Pokémon land");
        public static Ability Normalize = new Ability("Normalize", "All the Pokémon's moves become the Normal type");
        public static Ability Oblivious = new Ability("Oblivious", "Prevents it from becoming infatuated");
        public static Ability Overcoat = new Ability("Overcoat", "Protects the Pokémon from damage from weather");
        public static Ability Overgrow = new Ability("Overgrow", "Powers up Grass-type moves in a pinch");
        public static Ability OwnTempo = new Ability("Own Tempo", "Prevents the Pokémon from becoming confused");
        public static Ability ParentalBond = new Ability("Parental Bond", "Allows the Pokémon to attack twice");
        public static Ability Pickpocket = new Ability("Pickpocket", "Steals an item when hit by another Pokémon");
        public static Ability Pickup = new Ability("Pickup", "The Pokémon may pick up items");
        public static Ability Pixilate = new Ability("Pixilate", "Turns Normal-type moves into Fairy-type moves");
        public static Ability Plus = new Ability("Plus", "Ups Sp Atk if another Pokémon has Plus or Minus");
        public static Ability PoisonHeal = new Ability("Poison Heal", "Restores HP if the Pokémon is poisoned");
        public static Ability PoisonPoint = new Ability("Poison Point", "Contact with the Pokémon may poison the attacker");
        public static Ability PoisonTouch = new Ability("Poison Touch", "May poison targets when a Pokémon makes contact");
        public static Ability PowerConstruct= new Ability("Power Construct", "Changes form when HP drops below half");
        public static Ability PowerofAlchemy = new Ability("Power of Alchemy", "The Pokémon copies the Ability of a defeated ally");
        public static Ability Prankster = new Ability("Prankster", "Gives priority to a status move");
        public static Ability Pressure = new Ability("Pressure", "The Pokémon raises the foe's PP usage");
        public static Ability PrimordialSea =  new Ability("Primordial Sea", "Makes it rain heavily when the ability activates");
        public static Ability PrismArmor = new Ability("Prism Armor", "Reduces the power of supereffective attacks taken");
        public static Ability Protean = new Ability("Protean", "Changes the Pokémon's type to its last used move");
        public static Ability PsychicSurge = new Ability("Psychic Surge", "The Pokémon creates a Psychic Terrain when it enters a battle");
        public static Ability PurePower = new  Ability("Pure Power", "Raises the Pokémon's Attack stat");
        public static Ability QueenlyMajesty= new Ability("Queenly Majesty", "Prevents use of priority moves");
        public static Ability QuickFeet = new  Ability("Quick Feet", "Boosts Speed if there is a status problem");
        public static Ability RainDish = new Ability("Rain Dish", "The Pokémon gradually regains HP in rain");
        public static Ability Rattled = new Ability("Rattled", "Bug, Ghost or Dark type moves scare it and boost its Speed");
        public static Ability Receiver = new Ability("Receiver", "Inherits an ally's ability when it faints");
        public static Ability Reckless = new Ability("Reckless", "Powers up moves that have recoil damage");
        public static Ability Refrigerate = new Ability("Refrigerate", "Turns Normal-type moves into Ice-type moves");
        public static Ability Regenerator = new Ability("Regenerator", "Restores a little HP when withdrawn from battle");
        public static Ability Rivalry = new Ability("Rivalry", "Deals more damage to a Pokémon of same gender");
        public static Ability RKSSystem = new  Ability("RKS System", "Changes type depending on held item");
        public static Ability RockHead = new Ability("Rock Head", "Protects the Pokémon from recoil damage");
        public static Ability RoughSkin = new  Ability("Rough Skin", "Inflicts damage to the attacker on contact");
        public static Ability RunAway = new Ability("Run Away", "Enables a sure getaway from wild Pokémon");
        public static Ability SandForce = new Ability("Sand Force", "Boosts certain moves' power in a sandstorm");
        public static Ability SandRush = new Ability("Sand Rush", "Boosts the Pokémon's Speed in a sandstorm");
        public static Ability SandStream = new Ability("Sand Stream", "The Pokémon summons a sandstorm in battle");
        public static Ability SandVeil = new Ability("Sand Veil", "Boosts the Pokémon's evasion in a sandstorm");
        public static Ability SapSipper = new Ability("Sap Sipper", "Boosts Attack when hit by a Grass-type move");
        public static Ability Schooling = new Ability("Schooling", "Changes Wishiwashi to School form");
        public static Ability Scrappy = new Ability("Scrappy", "Enables moves to hit Ghost-type Pokémon");
        public static Ability SereneGrace = new Ability("Serene Grace", "Boosts the likelihood of added effects appearing");
        public static Ability ShadowShield = new Ability("Shadow Shield", "Reduces damage when HP is full");
        public static Ability ShadowTag = new Ability("Shadow Tag", "Prevents the foe from escaping");
        public static Ability ShedSkin  = new Ability("Shed Skin", "The Pokémon may heal its own status problems");
        public static Ability SheerForce = new Ability("Sheer Force", "Removes added effects to increase move damage");
        public static Ability ShellArmor = new Ability("Shell Armor", "The Pokémon is protected against critical hits");
        public static Ability ShieldDust = new Ability("Shield Dust", "Blocks the added effects of attacks taken");
        public static Ability ShieldsDown = new Ability("Shields Down", "Changes stats when HP drops below half");
        public static Ability Simple = new Ability("Simple", "Doubles all stat changes");
        public static Ability SkillLink = new Ability("Skill Link", "Increases the frequency of multi-strike moves");
        public static Ability SlowStart = new Ability("Slow Start", "Temporarily halves Attack and Speed");
        public static Ability SlushRush = new Ability("Slush Rush", "Boosts the Pokémon’s Speed stat in a hailstorm");
        public static Ability Sniper = new Ability("Sniper", "Powers up moves if they become critical hits");
        public static Ability SnowCloak = new Ability("Snow Cloak", "Raises evasion in a hailstorm");
        public static Ability SnowWarning = new Ability("Snow Warning", "The Pokémon summons a hailstorm in battle");
        public static Ability SolarPower = new Ability("Solar Power", "In sunshine, Sp Atk is boosted but HP decreases");
        public static Ability SolidRock = new Ability("Solid Rock", "Reduces damage from supereffective attacks");
        public static Ability SoulHeart = new Ability("Soul-Heart", "Raises Special Attack when an ally faints");
        public static Ability Soundproof = new Ability("Soundproof", "Gives immunity to sound-based moves");
        public static Ability SpeedBoost = new Ability("Speed Boost", "Its Speed stat is gradually boosted");
        public static Ability Stakeout = new Ability("Stakeout", "Deals double damage to Pokémon switching in");
        public static Ability StallThe = new Ability("StallThe ", "Pokémon moves after all other Pokémon do");
        public static Ability Stamina = new Ability("Stamina", "Raises Defense when attacked");
        public static Ability StanceChange = new Ability("Stance Change", "Changes form depending on moves used");
        public static Ability Static = new Ability("Static", "Contact with the Pokémon may cause paralysis");
        public static Ability Steadfast = new Ability("Steadfast", "Raises Speed each time the Pokémon flinches");
        public static Ability Steelworker = new Ability("Steelworker", "Powers up Steel-type moves");
        public static Ability Stench = new Ability("Stench", "The stench may cause the target to flinch");
        public static Ability StickyHold = new Ability("Sticky Hold", "Protects the Pokémon from item theft");
        public static Ability StormDrain = new Ability("Storm Drain", "Draws in all Water-type moves to up Sp Attack");
        public static Ability StrongJaw = new Ability("Strong Jaw", "Boosts the power of biting moves");
        public static Ability Sturdy = new Ability("Sturdy", "It cannot be knocked out with one hit");
        public static Ability SuctionCups = new Ability("Suction Cups", "Negates all moves that force switching out");
        public static Ability SuperLuck = new Ability("Super Luck", "Heightens the critical-hit ratios of moves");
        public static Ability SurgeSurfer = new Ability("Surge Surfer", "Doubles Speed during Electric Terrain");
        public static Ability Swarm = new Ability("Swarm", "Powers up Bug-type moves in a pinch");
        public static Ability SweetVeil = new Ability("Sweet Veil", "Prevents the Pokémon and allies from falling asleep");
        public static Ability SwiftSwim = new Ability("Swift Swim", "Boosts the Pokémon's Speed in rain");
        public static Ability Symbiosis = new Ability("Symbiosis", "The Pokémon can pass an item to an ally");
        public static Ability Synchronize = new Ability("Synchronize", "Passes a burn, poison, or paralysis to the foe");
        public static Ability TangledFeet = new Ability("Tangled Feet", "Raises evasion if the Pokémon is confused");
        public static Ability TanglingHair = new Ability("Tangling Hair", "Contact with the Pokémon lowers the attacker’s Speed stat");
        public static Ability Technician = new Ability("Technician", "Powers up the Pokémon's weaker moves");
        public static Ability Telepathy = new Ability("Telepathy", "Anticipates an ally's attack and dodges it");
        public static Ability Teravolt = new Ability("Teravolt", "Moves can be used regardless of Abilities");
        public static Ability ThickFat = new Ability("Thick Fat", "Ups resistance to Fire- and Ice-type moves");
        public static Ability TintedLens = new Ability("Tinted Lens", "Powers up “not very effective” moves");
        public static Ability Torrent = new Ability("Torrent", "Powers up Water-type moves in a pinch");
        public static Ability ToughClaws = new Ability("Tough Claws", "Boosts the power of contact moves");
        public static Ability ToxicBoost = new Ability("Toxic Boost", "Powers up physical attacks when poisoned");
        public static Ability Trace = new Ability("Trace", "The Pokémon copies a foe's Ability");
        public static Ability Triage = new Ability("Triage", "Gives priority to restorative moves");
        public static Ability Truant = new Ability("Truant", "Pokémon can't attack on consecutive turns");
        public static Ability Turboblaze = new Ability("Turboblaze", "Moves can be used regardless of Abilities");
        public static Ability Unaware = new Ability("Unaware", "Ignores any stat changes in the Pokémon");
        public static Ability Unburden = new Ability("Unburden", "Raises Speed if a held item is used");
        public static Ability Unnerve = new Ability("Unnerve", "Makes the foe nervous and unable to eat Berries");
        public static Ability VictoryStar = new Ability("Victory Star", "Boosts the accuracy of its allies and itself");
        public static Ability VitalSpirit = new Ability("Vital Spirit", "Prevents the Pokémon from falling asleep");
        public static Ability VoltAbsorb = new Ability("Volt Absorb", "Restores HP if hit by an Electric-type move");
        public static Ability WaterAbsorb = new Ability("Water Absorb", "Restores HP if hit by a Water-type move");
        public static Ability WaterBubble = new Ability("Water Bubble", "Lowers the power of Fire-type moves and prevents burns");
        public static Ability WaterCompaction = new Ability("Water Compaction", "Sharply raises Defense when hit by a Water-type move");
        public static Ability WaterVeil = new Ability("Water Veil", "Prevents the Pokémon from getting a burn");
        public static Ability WeakArmor = new Ability("Weak Armor", "Physical attacks lower Defense and raise Speed");
        public static Ability WhiteSmoke = new Ability("White Smoke", "Prevents other Pokémon from lowering its stats");
        public static Ability WimpOut = new Ability("Wimp Out", "Switches out when HP drops below half");
        public static Ability WonderGuard = new Ability("Wonder Guard", "Only supereffective moves will hit");
        public static Ability WonderSkin = new Ability("Wonder Skin", "Makes status-changing moves more likely to miss");
        public static Ability ZenMode = new Ability("Zen Mode", "Changes form when HP drops below half");
    }
}
