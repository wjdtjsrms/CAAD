using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelServices : MonoBehaviour
{
    public void OpenAEDPage()
    {
        Application.OpenURL("https://www.e-gen.or.kr/egen/search_aed.do");
    }
}
