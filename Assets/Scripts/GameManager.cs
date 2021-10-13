﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject GameCanvas;
    public GameObject SceneCamera;

    public void SpawnPlayer()
    {
        float randomValue = Random.Range(-1f, 1f);

        PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector2(this.transform.position.x * randomValue, this.transform.position.y), Quaternion.identity, 0);
        GameCanvas.SetActive(false);
        SceneCamera.SetActive(false);
    }
}
