using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageText : MonoBehaviour
{
    [SerializeField] Text message;
    [SerializeField] float speed;

    private int page = 0;
    private int m_page = 0;

    private string display = string.Empty;

    float count;
    int currentText = 0;

    private bool finish = false;
    public bool Finish { get { return finish; } }

    LoadText loadText;

    [SerializeField] Image fadeTarget;

    bool fading = false;
    bool flag = true;

    IEnumerator textMessage;
    CharacterFace characterFace;

    void Start()
    {
        loadText = GetComponent<LoadText>();
    }

    IEnumerator fadeout()
    {
        message.text = string.Empty;
        float alpha = 1f;
        while (alpha >= 0)
        {
            yield return new WaitForSeconds(0.05f);
            alpha -= 0.03f;
            Color nextColor = new Color(fadeTarget.color.r, fadeTarget.color.g, fadeTarget.color.b, alpha);
            this.fadeTarget.color = nextColor;
        }

        flag = true;
        fading = false;
        yield break;
    }

    IEnumerator fadein()
    {
        fading = true;
        flag = false;

        float alpha = 0;
        while (alpha <= 1)
        {
            yield return new WaitForSeconds(0.05f);
            alpha += 0.03f;
            Color nextColor = new Color(fadeTarget.color.r, fadeTarget.color.g, fadeTarget.color.b, alpha);
            this.fadeTarget.color = nextColor;
        }
        yield break;
    }

    void Update()
    {
        display = loadText.MessageText;
        page = loadText.RowLength;

        if (!flag && Input.GetMouseButtonDown(0))
        {
            StartCoroutine("fadeout");
        }

        if (!fading && flag)
        {
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
                    if (loadText.FadeIn == 1)
                    {
                        StartCoroutine("fadein");  
                    }
                    finish = false;
                    loadText.Page++;
                }
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
