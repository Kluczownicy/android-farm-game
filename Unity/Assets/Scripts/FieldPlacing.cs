using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FieldPlacing : MonoBehaviour
{
    public GameObject nowePole;
    bool isPlacing = FieldPlacingBtnHandler.isPlacingFields;
    void Update()
    {
        isPlacing = FieldPlacingBtnHandler.isPlacingFields;
        if (isPlacing)
        {
            nowePole.transform.position = Input.mousePosition;
            if (Input.GetMouseButtonDown(0))
                Instantiate(nowePole, Input.mousePosition, Quaternion.identity);
        }
    }
}
