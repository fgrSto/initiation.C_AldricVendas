using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonData : MonoBehaviour
{

    //Var for the characteristics of our pokemon
    [SerializeField] private string Name = "Duskull";
    [SerializeField] private int MaxLife = 20;
    private int CurentLife = 0;
    [SerializeField] private int Attack = 40;
    [SerializeField] private int Defense = 90;
    [SerializeField] private float Weight = 12.4f;

    //All pokemon type list
    private enum Type
    {
        Bug,
        Dark,
        Dragon,
        Electric,
        Fairy,
        Fighting,
        Fire,
        Flying,
        Ghost,
        Grass,
        Ground,
        Ice,
        Normal,
        Poison,
        Spychic,
        Rock,
        Steel,
        Water
    }

    [SerializeField] private Type _Type;

    //Weakness and resistance of our pokemon
    [SerializeField] private string[] Weakness = {"Ghost","Dark"};
    [SerializeField] private string[] Resistance = {"Bug","Poison"};



    void Start()
    {
        //Setting the right number of some variable
        int CurentLife = MaxLife;
        int Stats = MaxLife + Attack + Defense;
        int AttackDamage = Attack;
        int Dmg = 10; //Damage of the attack
        int attType = 1; //The type of the attack (see the type list)

        //Calculation the attack modifier
        if (attType == 0 || attType == 8)
        {
            Dmg *=2;
        }
        if (attType == 1 || attType == 13)
        {
            Dmg /=2;
        }

        //Display all of our needing
        Debug.Log("Pokemon is " + Name);
        Debug.Log("Type is " + _Type);
        Debug.Log("Life = " + MaxLife);
        Debug.Log("Attack = " + Attack);
        Debug.Log("Defense = " + Defense);
        Debug.Log("Stats = " + Stats);
        Debug.Log("Weigth = " + Weight);
        Debug.Log("Weakness = " + Weakness[0] + " " + Weakness[1]);
        Debug.Log("Strongness = " + Resistance[0] + " " + Resistance[1]);
        CurentLife = CurentLife - Dmg;
        Debug.Log("Damage deal !");
        Debug.Log("Life = " + CurentLife);
    }

    void Update()
    {
        //Check if our pokemon is alive
        if (CurentLife < 0)
        {
            Debug.Log("Pokemon is dead");
        }
        else
        {
            Debug.Log("Pokemon is Alive");
        }

    }
}