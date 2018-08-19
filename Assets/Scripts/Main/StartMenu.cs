using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Image selectStart;
    public Image selectOptions;
    public RectTransform startLogo;

    public GameObject startButton;
    public GameObject optionsButton;

    public void SelectStart()
    {
        selectStart.gameObject.SetActive(true);
        selectOptions.gameObject.SetActive(false);
    }

    public void SelectOptions()
    {
        selectStart.gameObject.SetActive(false);
        selectOptions.gameObject.SetActive(true);
    }

    public IEnumerator HideScreen()
    {
        Vector3 startPosition = startLogo.transform.localPosition;
         
        for (float f = 0f; f < 0.5f; f += 1f * Time.deltaTime)
        {
            startLogo.localPosition = Vector3.Lerp(startPosition, 
                new Vector3(0f, 128f, 0f), f/0.5f);
            yield return new WaitForSeconds(1f * Time.deltaTime);
        }

        yield return null;

        startButton.SetActive(false);
        optionsButton.SetActive(false);
        startLogo.gameObject.SetActive(false);
    }
}
