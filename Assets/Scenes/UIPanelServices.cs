using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelServices : MonoBehaviour
{
    public async void OpenAEDPage()
    {
        Application.OpenURL("https://www.e-gen.or.kr/egen/search_aed.do");
    }
}
