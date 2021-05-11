using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image image;

    public void SetPosition(int position)
    {
        gameObject.SetActive(true);
       // transform.position = new Vector3((position*2), position, 0);
    }
}
