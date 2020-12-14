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

    void Start()
    {
        if (m_mode == Fade.FadeIn)
        {
            a = 0;
            fade.color = new Color(1, 1, 1, a);
        }
        if (m_mode == Fade.FadeOut)
        {
            a = 1;
            fade.color = new Color(0, 0, 0, a);
        }
    }

    void Update()
    {
        if (m_mode == Fade.FadeIn)
        {
            if (Input.GetMouseButtonDown(0) && !fadeIn)
            {
                fadeIn = true;
            }

            if (fadeIn)
            {
                fade.color = new Color(0, 0, 0, a);
                a += 0.01f;
                if (a > 1)
                {
                    fadeIn = false;
                    a = 1;
                }
            }
        }
        else if (m_mode == Fade.FadeOut)
        {
            if (Input.GetMouseButtonDown(0) && !fadeOut)
            {
                fadeOut = true;
            }

            if (fadeOut)
            {
                fade.color = new Color(0, 0, 0, a);
                a -= 0.01f;
                if (a < 0)
                {
                    fadeOut = false;
                    a = 0;
                }
            }
        }
    }
}

public enum Fade
{
    FadeIn,
    FadeOut,
}
