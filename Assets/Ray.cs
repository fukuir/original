using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            //メインカメラ上のマウスカーソルのある位置からRayを飛ばす
            UnityEngine.Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //レイヤーマスク作成
            //int layerMask = LayerMaskNo.DEFAULT;

            //Rayの長さ
            float maxDistance = 10;

            // RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance, layerMask);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);
            //クリックしたオブジェクトを削除する
            if (hit.collider)
            {
                Debug.Log(hit.collider.gameObject.name);
                Destroy(hit.collider.gameObject);
            }
        }
    }
}