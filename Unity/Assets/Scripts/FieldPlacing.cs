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
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

        isPlacing = FieldPlacingBtnHandler.isPlacingFields;
        if (isPlacing)
        {
            nowePole.transform.position = worldPosition;
            if (Input.GetMouseButtonUp(0))
                Instantiate(nowePole, worldPosition, Quaternion.identity);
        }
    }
}
