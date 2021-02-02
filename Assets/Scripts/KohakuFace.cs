using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KohakuFace : MonoBehaviour
{
    [SerializeField] Image character;

    int facial;

    [SerializeField] GameObject novelGameManager;
    LoadText loadText;
    CharacterName characterName;
    CharacterPosition characterPosition;

    string nowTalk;

    void Start()
    {
        novelGameManager = GameObject.FindGameObjectWithTag("NovelGameManager");
        loadText = novelGameManager.GetComponent<LoadText>();
        characterName = novelGameManager.GetComponent<CharacterName>();
        characterPosition = novelGameManager.GetComponent<CharacterPosition>();
    }


    void Update()
    {
        nowTalk = characterName.CharaName;

        facial = loadText.Face;

        if (nowTalk == "コハク")
        {
            switch (facial)
            {
                case 1:
                    if (loadText.Position == 1)
                    {
                        characterPosition.Character1Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/01");
                    }
                    else if (loadText.Position == 2)
                    {
                        characterPosition.Character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/01");
                    }

                    break;

                case 2:

                    if (loadText.Position == 1)
                    {
                        characterPosition.Character1Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/02");
                    }
                    else if (loadText.Position == 2)
                    {
                        characterPosition.Character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/02");
                    }

                    break;

                case 3:

                    if (loadText.Position == 1)
                    {
                        characterPosition.Character1Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/03");
                    }
                    else if (loadText.Position == 2)
                    {
                        characterPosition.Character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/03");
                    }

                    break;

                case 4:

                    if (loadText.Position == 1)
                    {
                        characterPosition.Character1Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/04");
                    }
                    else if (loadText.Position == 2)
                    {
                        characterPosition.Character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/04");
                    }

                    break;

                case 5:

                    if (loadText.Position == 1)
                    {
                        characterPosition.Character1Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/05");
                    }
                    else if (loadText.Position == 2)
                    {
                        characterPosition.Character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/05");
                    }

                    break;

                case 6:

                    if (loadText.Position == 1)
                    {
                        characterPosition.Character1Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/06");
                    }
                    else if (loadText.Position == 2)
                    {
                        characterPosition.Character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/06");
                    }

                    break;
            }
        }
        else
        {
            //character.color = new Color(125f / 255f, 125f / 255f, 125f / 255f);
        }

    }
}