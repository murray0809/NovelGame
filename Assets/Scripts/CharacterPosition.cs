using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPosition : MonoBehaviour
{
    [SerializeField] Image character1Image;
    public Image Character1Image { get { return character1Image; } }
    [SerializeField] Image character2Image;
    public Image Character2Image { get { return character2Image; } }

    public GameObject gObj; //uGUIのGameObject
    public GameObject character1; //上の奴の子にするprefab
    public GameObject character2; //上の奴の子にするprefab

    void Start()
    {
        //character1Image = GetComponent<Image>();
        //character1Image.sprite = Resources.Load<Sprite>("UnityChan/Misaki/01");
        //character2Image.sprite = Resources.Load<Sprite>("UnityChan/Kohaku/01");

        //GameObject ui = Instantiate((GameObject)character1);
        //ui.transform.SetParent(gObj.transform,false);
        //Image a = ui.GetComponentInChildren<Image>();
        //a.rectTransform.anchoredPosition = new Vector2(50, -350);

        //GameObject ui2 = Instantiate((GameObject)character2);
        //ui2.transform.SetParent(gObj.transform, false);
    }

    void Update()
    {
        
    }
}
