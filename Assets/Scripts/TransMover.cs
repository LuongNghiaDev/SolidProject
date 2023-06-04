using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TransMover : MonoBehaviour
{
    public GameObject cube;
    public RectTransform mainMenu;
    public RectTransform mainMenu1;
    public RectTransform mainMenu2;
    Tween tween;
    public PathType pathType = PathType.CatmullRom;
    public Vector3[] pathVal = new Vector3[3];

    // Start is called before the first frame update
    void Start()
    {
        //Do Move x
        //cube.transform.DOMove(new Vector3(10, 0, 0), 1);
        //Do Move x,y
        //cube.transform.DOMove(new Vector3(10, 5, 0), 1);
        //Do MoveX
        //cube.transform.DOMoveX(15, 1);

        //Do Jump
        /*        cube.transform.DOJump(new Vector3(10, 0, 0), 5, 1, 1 , false);*/

        //Do Rotate
        //cube.transform.DORotate(new Vector3(150f, 0, 0), 1, RotateMode.Fast);

        //tween = cube.transform.DOMove(new Vector3(10, 0, 0), 3);
        //tween.Pause();

        tween = cube.transform.DOPath(pathVal, 4, pathType);
        tween.SetEase(Ease.Linear).SetLoops(-1);
    }

    public void btnOpen1()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 1033), 1, false);
        mainMenu1.DOAnchorPos(new Vector2(0, 0), 1, false);
    }

    public void btnOpen2()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 1033), 1, false);
    }

    public void PlayHome()
    {
        tween.Play();
    }

    public void RestartHome()
    {
        tween.Restart();
    }
    
    public void ReWindHome()
    {
        tween.Rewind();
    }
}
