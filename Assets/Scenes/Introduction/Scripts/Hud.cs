using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public TMP_Text ExpText;
    public TMP_Text LevelText;
    public static int score = 0;
    public Image Health_Image;
    public Image Mana_Image;
    public Image Exp_Image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Wizard w = Wizard.player;
        PlayerStats s = w.stats;
        float maxMana = s.maxMana;
        int maxHP =(int) s.maxHP;
        int maxExp =(int) s.maxExp;
        int displayMana = (int)w.mana;
       



        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + (int)w.hp + "/" + maxHP;
        manaText.text = "Mana: " + displayMana + "/" + maxMana;
        ExpText.text = "Exp: " + w.stats.Exp + "/" + maxExp;
        LevelText.text = "Level: " + w.stats.C_Level;

        // Testing
        //gameObject.SetActive(!gameObject.activeSelf);


        float HealtPercent = w.hp / maxHP;
        Health_Image.transform.localScale = new Vector3(HealtPercent, 1, 1);

        float ManaPercent = w.mana / maxMana;
        Mana_Image.transform.localScale = new Vector3(ManaPercent, 1, 1);
       
        float ExpPercent = (float)w.stats.Exp / maxExp;
        Exp_Image.transform.localScale = new Vector3(ExpPercent, 1, 1);

    }
}
