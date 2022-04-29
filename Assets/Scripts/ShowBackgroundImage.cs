using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBackgroundImage : MonoBehaviour
{
    DataTracker dt = DataTracker.Instance;
    public Image blackBG;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeBlackBG(false));
    }

    // Update is called once per frame
    void Update()
    {
        if (dt.showBackgroundImage >= 1)
        {
            StartCoroutine(FadeBlackBG());
        } else if (dt.showBackgroundImage <= 0)
        {
            StartCoroutine(FadeBlackBG(false));
        }
    }

    

    public IEnumerator FadeBlackBG(bool fadeToBlack = true, int fadeSpeed = 5)
    {
        Color objectColor = blackBG.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToBlack)
        {
            while (blackBG.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackBG.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        } else
        {
            while (blackBG.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackBG.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
}
