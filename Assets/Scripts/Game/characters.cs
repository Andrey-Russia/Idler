/*using System.Collections.Generic;
using static UnityEditor.Progress;

public abstract class characters 
{
    public int Level { get; protected set; }
    public string Name { get; protected set; }
    public int HP { get; protected set; }
    public int Endurance { get; protected set; }
    public int Defence { get; protected set; }
    public int Skills { get; protected set; }
    public int Strength { get; protected set; }
    public int Agility { get; protected set; }
    public int Stamina { get; protected set; }
    public int Luck { get; protected set; }

    public List<Item> Inventory { get; protected set; }

    public Equipment EquipmentItems { get; private set; }

    public characters (string name, int hp, int endurance, int defense,
                     int skill, int strength, int agility, int stamina, int luck)
    {
        this.Name = name;
        this.HP = hp;
        this.Endurance = endurance;
        this.Defence = defense;
        this.Skills = skill;
        this.Strength = strength;
        this.Agility = agility;
        this.Stamina = stamina;
        this.Luck = luck;


        this.Inventory = new List<Item> ();
        this.EquipmentItems = new Equipment();
    }

    public virtual void LevelUp() => this.Level++;
}

public abstract class Item
{
    public string Name { get; protected set; }
    public RarityType Rarity { get; protected set; }

    public Item(string name, RarityType rarity)
    {
       this.Name = name;
       this.Rarity = rarity;
    }

    public abstract void ApplyEfect(characters characters);
}

public class Equipment
{

}
*/