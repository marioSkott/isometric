using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayTiles : MonoBehaviour
{
    public int G;
    public int H;
    public int F { get { return G + H; } }

    public bool isBlocked = false;

    public OverlayTiles Previous;

    public Vector3Int gridLocation;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HideTile();
        }
    }

    public void HideTile()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

}

