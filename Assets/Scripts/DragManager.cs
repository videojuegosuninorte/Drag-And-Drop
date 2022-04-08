using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManager : MonoBehaviour
{
    public static DragManager Instance;

    private void Awake()
    {
        Instance = this;
    }


    public Cell GetNearObject(Vector2 pos)
    {
        int c = 0;
        List<Cell> cells = BoardManager.Instance.getCells();
        foreach (Cell item in cells)
        {
            float d = Vector2.Distance(item.Position, pos);
            Debug.Log("GetNearObject " + c + " " + d);
            if (d < 1)
            {
                return item;
            }
        }

        return null;
    }


}
