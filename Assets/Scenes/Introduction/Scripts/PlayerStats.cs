using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEditor.Profiling;

public class PlayerStats
{
    public float movementSpeed = 1.5f;
    public float castingTime = 1.5f;
    public float maxHP = 100;
    public float maxMana = 50;
    public int maxLevel = 10;
    public float maxExp = 200;
    public float Exp = 0;
    public int C_Level=1;

    public float manaRegeneration = 5;
    public float healthRegeneration = 5;



    public void LevelUp() {

        maxHP = (float)(maxHP + (maxHP * 0.25));
        maxMana = (float)(maxMana + (maxMana * 0.25));
        maxExp =(float)(maxExp + (maxExp * 0.80));
        healthRegeneration =(float)( healthRegeneration +(healthRegeneration*0.25)); 
        C_Level++;

    }

    public void GainEXP(int newExp) {
        Exp = Exp + newExp;

        // Level UP ;
        if (Exp >= maxExp)
        {
            Exp -= maxExp;
            LevelUp();

        }
    }
}
