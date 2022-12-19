/*
AUTHOR DD/MM/YY: Kaleb 04/10/22

	- EDITOR DD/MM/YY CHANGES:
    - Kaleb 11/12/22 Beastiary Setup
    - Kaleb 19/12/22 Singleton setup
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //Variable for ensuring there is only one GameManager
    public static GameManager instance = null;

    public GameObject[] spellSlots;

    public EnemyScriptableObject[] beastiaryArray;

    private Dictionary<EnemyScriptableObject, bool> beastiary = new Dictionary<EnemyScriptableObject, bool>();

    private int totalBeasts;

    void Awake()
    {
        //If there is no gameManager, set this to the gameManager, otherwise destroy this
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        spellSlots = GameObject.FindGameObjectsWithTag("SpellSlot");

        UpdateSpellSlots(PlayerManager.instance.totalBeasts);
        UpdateDisplayedSpell(0);

        //Initialise the beastiary if it isn't intialised. Set all beast unlocks to false
        if (beastiary.Count == 0)
        {
            foreach (EnemyScriptableObject enemy in beastiaryArray)
            {
                beastiary.Add(enemy, false);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateSpellSlots(int beastMax)
    {
        totalBeasts = beastMax;

        for (int i = 0; i < spellSlots.Length; i++)
        {
            if (i > totalBeasts - 1)
            {
                spellSlots[i].SetActive(false);
            }
            else
            {
                spellSlots[i].SetActive(true);
            }
        }
    }

    public void UpdateDisplayedSpell(int index)
    {
        for (int i = 0; i < totalBeasts; i++)
        {
            if (i == index)
            {
                spellSlots[i].transform.localScale = 1.5f * Vector3.one;
                spellSlots[i].GetComponent<Image>().color = Color.white;
            }
            else
            {
                spellSlots[i].transform.localScale = 1f * Vector3.one;
                spellSlots[i].GetComponent<Image>().color = new Color(0.25f, 0.25f, 0.25f);
            }
        }
    }

    //Method for setting a beast to be unlocked
    public void setBeastiary(EnemyScriptableObject enemy)
    {
        beastiary[enemy] = true;
    }

    //Method for getting whether a beast is or is not unlocked
    public bool getBeastiary(EnemyScriptableObject enemy)
    {
        return beastiary[enemy];
    }
}
