using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceChange : MonoBehaviour
{
    [SerializeField] Image character;

    private Sprite[] misakiFace = new Sprite[6];

    int facial;

    [SerializeField] GameObject novelGameManager;
    LoadText loadText;
    void Start()
    {
        novelGameManager = GameObject.FindGameObjectWithTag("NovelGameManager");
        loadText = novelGameManager.GetComponent<LoadText>();
    }

    
    void Update()
    {
        facial = loadText.Face;

        switch (facial)
        {
            case 1:
                if (this.gameObject.CompareTag("Kohaku"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/01");
                }
                else if (this.gameObject.CompareTag("Misaki"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/01");
                }

                break;
               
            case 2:
                if (this.gameObject.CompareTag("Kohaku"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/02");
                }
                else if (this.gameObject.CompareTag("Misaki"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/02");
                }

                break;

            case 3:
                if (this.gameObject.CompareTag("Kohaku"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/03");
                }
                else if (this.gameObject.CompareTag("Misaki"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/03");
                }

                break;

            case 4:
                if (this.gameObject.CompareTag("Kohaku"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/04");
                }
                else if (this.gameObject.CompareTag("Misaki"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/04");
                }

                break;

            case 5:
                if (this.gameObject.CompareTag("Kohaku"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/05");
                }
                else if (this.gameObject.CompareTag("Misaki"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/05");
                }

                break;

            case 6:
                if (this.gameObject.CompareTag("Kohaku"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/06");
                }
                else if (this.gameObject.CompareTag("Misaki"))
                {
                    character.sprite = Resources.Load<Sprite>("UnityChan/Misaki/06");
                }

                break;

        }
    }

    void Character1Talk()
    {
        character.color = new Color(1f, 1f, 1f);
    }

    void Character2Talk()
    {
        character.color = new Color(125f / 255f, 125f / 255f, 125f / 255f);
    }
}
