using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour
{
    private string charaName;

    [SerializeField] Text characterName;

    LoadText loadText;
    void Start()
    {
        loadText = GetComponent<LoadText>();
    }

    void Update()
    {
        charaName = loadText.CharacterName;

        characterName.text = charaName;
    }
}
