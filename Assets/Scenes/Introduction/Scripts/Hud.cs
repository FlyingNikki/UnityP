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
        PlayerStats s = Wizard.stats;
        float maxMana = Wizard.stats.maxMana;
        int maxHP =(int) Wizard.stats.maxHP;
        int maxExp =(int) Wizard.stats.maxExp;
        int displayMana = (int)w.mana;
       

        int score = GameManager.Instance.Score;

        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + (int)w.hp + "/" + maxHP;
        manaText.text = "Mana: " + displayMana + "/" + maxMana;
        ExpText.text = "Exp: " + Wizard.stats.Exp + "/" + maxExp;
        LevelText.text = "Level: " + Wizard.stats.C_Level;

        // Testing
        //gameObject.SetActive(!gameObject.activeSelf);


        float HealtPercent = w.hp / maxHP;
        Health_Image.transform.localScale = new Vector3(HealtPercent, 1, 1);

        float ManaPercent = w.mana / maxMana;
        Mana_Image.transform.localScale = new Vector3(ManaPercent, 1, 1);
       
        float ExpPercent = (float)Wizard.stats.Exp / maxExp;
        Exp_Image.transform.localScale = new Vector3(ExpPercent, 1, 1);

    }
}
