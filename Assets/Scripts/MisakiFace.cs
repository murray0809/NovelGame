using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MisakiFace : MonoBehaviour
{
    [SerializeField] Image character;

    int facial;

    [SerializeField] GameObject novelGameManager;
    LoadText loadText;
    CharacterName characterName;

    string nowTalk;

    void Start()
    {
        novelGameManager = GameObject.FindGameObjectWithTag("NovelGameManager");
        loadText = novelGameManager.GetComponent<LoadText>();
        characterName = novelGameManager.GetComponent<CharacterName>();
    }

    void Update()
    {
        nowTalk = characterName.CharaName;

        facial = loadText.Face;

        if (nowTalk == "ミサキ")
        {
            character.color = new Color(1f, 1f, 1f);

            switch (facial)
            {
                case 1:

                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/01");

                    break;

                case 2:

                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/02");

                    break;

                case 3:

                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/03");

                    break;

                case 4:

                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/04");

                    break;

                case 5:

                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/05");

                    break;

                case 6:

                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/06");

                    break;
            }
        }
        else
        {
            character.color = new Color(125f / 255f, 125f / 255f, 125f / 255f);
        }
    }
}