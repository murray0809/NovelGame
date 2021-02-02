using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Image fade;

    private float a = 0;

    private bool fadeIn = false;
    private bool fadeOut = false;

    [SerializeField] Fade m_mode;

    [SerializeField] GameObject novelGameManager;
    LoadText loadText;

    public Image fadeTarget;// fadeoutするスプライトの対象

    private bool canFade = true;

    IEnumerator fadeout()
    {
        float alpha = 1f;
        while (alpha >= 0)
        {
            // 残り時間が0以上の場合はタイマーを更新　
            yield return new WaitForSeconds(0.05f);
            alpha -= 0.03f;
            Color nextColor = new Color(fadeTarget.color.r, fadeTarget.color.g, fadeTarget.color.b, alpha);
            this.fadeTarget.color = nextColor;
            Debug.Log("b");
        }
    }

    IEnumerator fadein()
    {
        float alpha = 0;
        while (alpha <= 1)
        {
            // 残り時間が0以上の場合はタイマーを更新　
            yield return new WaitForSeconds(0.05f);
            alpha += 0.03f;
            Color nextColor = new Color(fadeTarget.color.r, fadeTarget.color.g, fadeTarget.color.b, alpha);
            this.fadeTarget.color = nextColor;
            Debug.Log("a");
        }
        if (alpha >= 1)
        {
            canFade = false;
        }
    }

    void Start()
    {
        novelGameManager = GameObject.FindGameObjectWithTag("NovelGameManager");
        loadText = novelGameManager.GetComponent<LoadText>();
        StartCoroutine("fadein");
        //if (m_mode == Fade.FadeIn)
        //{
        //    a = 0;
        //    fade.color = new Color(1, 1, 1, a);
        //}
        //if (m_mode == Fade.FadeOut)
        //{
        //    a = 1;
        //    fade.color = new Color(0, 0, 0, a);
        //}
    }

    void Update()
    {
        //if (m_mode == Fade.FadeIn)
        //{
        //    if (Input.GetMouseButtonDown(0) && !fadeIn)
        //    {
        //        fadeIn = true;
        //    }

        //    if (fadeIn)
        //    {
        //        fade.color = new Color(0, 0, 0, a);
        //        a += 0.01f;
        //        if (a > 1)
        //        {
        //            fadeIn = false;
        //            a = 1;
        //        }
        //    }
        //}
        //else if (m_mode == Fade.FadeOut)
        //{
        //    if (Input.GetMouseButtonDown(0) && !fadeOut)
        //    {
        //        fadeOut = true;
        //    }

        //    if (fadeOut)
        //    {
        //        fade.color = new Color(0, 0, 0, a);
        //        a -= 0.01f;
        //        if (a < 0)
        //        {
        //            fadeOut = false;
        //            a = 0;
        //        }
        //    }
        //}

        //if (canFade)
        //{
        //    Fade();
        //}
    }

    public void Fade()
    {
        if (loadText.FadeIn == 1)
        {
            StartCoroutine("fadein");
        }
        else if (loadText.FadeIn == 2)
        {
            StartCoroutine("fadeout");
        }
    }
}

public enum Fade
{
    FadeIn,
    FadeOut,
}
