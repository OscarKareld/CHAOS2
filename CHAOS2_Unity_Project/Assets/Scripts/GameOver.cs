using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image image;

    public void SetPosition(int position)
    {
        transform.position = new Vector3(400, 200, 0);
    }
}
