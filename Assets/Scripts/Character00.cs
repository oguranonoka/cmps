using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character00 : MonoBehaviour
{
    float HP = 1.0f;
    float AT = 1.2f;
    float DF = 0.8f;

    Vector3 previousPos, currentPos;
    const float LOAD_WIDTH = 10f;
    const float MOVE_MAX = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // スワイプによる移動処理
        if (Input.GetMouseButtonDown(0))
        {
            previousPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            currentPos = Input.mousePosition;
            float diffDistance_x = (currentPos.x - previousPos.x) / Screen.width * LOAD_WIDTH;
            float newX = Mathf.Clamp(transform.localPosition.x + diffDistance_x,-MOVE_MAX, MOVE_MAX);
            transform.localPosition = new Vector3(newX, 1, 0);

            // タップ位置を更新
            previousPos = currentPos;
        }
    }
}
