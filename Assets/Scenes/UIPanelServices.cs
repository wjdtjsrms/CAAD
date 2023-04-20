using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelServices : MonoBehaviour
{
    [SerializeField] private Toggle toggleCall;
    [SerializeField] private Toggle togglePlayCPR;
    [SerializeField] private Button btnFindNearAED;

    private AudioSource audioCPR;

    void Awake()
    {
        toggleCall.onValueChanged.AddListener(OnValuedChangeToggle119);
        togglePlayCPR.onValueChanged.AddListener(OnValueChangedToggleCPR);
        btnFindNearAED.onClick.AddListener(OpenAEDPage);

        audioCPR = togglePlayCPR.GetComponent<AudioSource>();
    }

    private void OnDestroy()
    {
        toggleCall.onValueChanged.RemoveAllListeners();
        togglePlayCPR.onValueChanged.RemoveAllListeners();
        btnFindNearAED.onClick.RemoveAllListeners();
    }

    public void OpenAEDPage()
    {
        Application.OpenURL("https://www.e-gen.or.kr/egen/search_aed.do");
    }

    public void OnValueChangedToggleCPR(bool isOn)
    {
        if (isOn)
            audioCPR.Play();
        else
            audioCPR.Stop();

        togglePlayCPR.graphic.gameObject.SetActive(isOn);
    }

    public void OnValuedChangeToggle119(bool isOn)
    {
        toggleCall.graphic.gameObject.SetActive(isOn);
    }
}
