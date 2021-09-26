using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldPlacingBtnHandler : MonoBehaviour
{
    public static bool isPlacingFields = false;
    public GameObject nowePole;
    public void startPlacingFields()
    {
        if (isPlacingFields)
        {
            isPlacingFields = false;
            nowePole.transform.position = new Vector3(437, -21);
        }

        else
        {
            isPlacingFields = true;
            Instantiate(nowePole, Input.mousePosition, Quaternion.identity);
        }
    }
}
