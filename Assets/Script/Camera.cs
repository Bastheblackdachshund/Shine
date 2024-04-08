using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject FrontC;
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
        if (Input.GetKeyDown("down"))
        {
            cam--;
        }
        if (cam == 1)
        {
            FrontC.SetActive(true);
            BackC.SetActive(false);
        }
        if (cam == 2)
        {
            FrontC.SetActive(false);
            TopC.SetActive(true);
        }
        if (cam == 3)
        {
            TopC.SetActive(false);
            MapC.SetActive(true);
        }
        if (cam == 4)
        {
            MapC.SetActive(false);
            MidRC.SetActive(true);
        }
        if (cam == 5)
        {
            MidRC.SetActive(false);
            MidLC.SetActive(true);
        }
        if (cam == 6)
        {
            MidLC.SetActive(false);
            BackC.SetActive(true);
        }
        if (cam >= 7) { cam = 1; }
    }
}
