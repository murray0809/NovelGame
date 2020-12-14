using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageText : MonoBehaviour
{
    [SerializeField] Text message;
    [SerializeField] float speed ;

    private int page = 0;
    private int m_page = 0;
   
    private string display = string.Empty;

    float count;
    int currentText = 0;

    private bool skip = false;

    private bool finish = false;
    public bool Finish { get { return finish; } }

    LoadText loadText;

    void Start()
    {
        loadText = GetComponent<LoadText>();
    }

    void Update()
    {
        display = loadText.MessageText;
        //Debug.Log(display);
        page = loadText.RowLength;

        if (!finish)
        {
            count += speed * Time.deltaTime;
            Message();
            if (Input.GetMouseButtonDown(0))
            {
                Skip();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0) && m_page < page)
            {
                finish = false;
            }
        }
    }

    void Message()
    {
        if (count > 1)
        {
            display = loadText.MessageText;
            message.text = display.Substring(0, currentText);
            currentText++;
            count = 0;
        }

        if (currentText > display.Length)
        {
            currentText = 0;
            m_page++;
            finish = true;
        }
    }

    void Skip()
    {
        message.text = display;
        finish = true;
        m_page++;
        currentText = 0;
    }
}
