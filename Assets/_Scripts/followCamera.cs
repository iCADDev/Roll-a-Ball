using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    [SerializeField] public Transform player;  // Oyuncunun Transform bileşeni
    public Vector3 offset = new Vector3(0, 5, -4); // Kamera konumunu ayarlar

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
 }

