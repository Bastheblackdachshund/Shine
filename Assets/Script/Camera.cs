using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject FrontC;
    public GameObject WheelC;
    public GameObject TopC;
    public GameObject MapC;
    public GameObject MidRC;
    public GameObject MidLC;
    public GameObject BackC;

    private int cam = 1;

    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            cam++;
        }
        if (cam == 1)
        {
            MapC.SetActive(true);
            BackC.SetActive(false);
        }
        if (cam == 2)
        {
            MapC.SetActive(false);
            TopC.SetActive(true);
        }
        if (cam == 3)
        {
            TopC.SetActive(false);
            WheelC.SetActive(true);
        }
        if (cam == 4)
        {
            WheelC.SetActive(false);
            FrontC.SetActive(true);
        }
        if (cam == 5)
        {
            FrontC.SetActive(false);
            MidRC.SetActive(true);
        }
        if (cam == 6)
        {
            MidRC.SetActive(false);
            MidLC.SetActive(true);
        }
        if (cam == 7)
        {
            MidLC.SetActive(false);
            BackC.SetActive(true);
        }
        if (cam >= 8) { cam = 1; }
    }
}
