using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuContent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        MoveToVisiblePositon();
    }

    private void MoveToVisiblePositon()
    {
        transform.DOMoveX(300f, 1f).SetEase(Ease.InOutQuad);
    }

    private void MoveToInVisiblePositon()
    {
        transform.DOMoveX(-250f, 1f).SetEase(Ease.InOutQuad);
    }





    public void OpenSettingMenu() { }

    public void CloseSettingMenu() { }

    public void StartGame() { }

    public void CloseGame() { }




}
