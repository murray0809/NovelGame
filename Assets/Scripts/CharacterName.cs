using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour
{
    private string charaName;
    public string CharaName { get { return charaName; } }

    [SerializeField] Text characterName;

    private string nowCharacter;
    public string NowCharacter { get { return nowCharacter; } }

    LoadText loadText;
    void Start()
    {
        loadText = GetComponent<LoadText>();
    }

    void Update()
    {
        charaName = loadText.CharacterName;

        characterName.text = charaName;

        if (charaName == "コハク")
        {

        }
        else if (charaName == "ミサキ")
        {

        }
    }
}