using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.Articy.Articy_1_4;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject prefab;
    public Rigidbody targetPrefab;
    public Rigidbody rockPrefab;
    private float spawnRate = 1.5f;
    private float spawnTimer = 0;
    private float startCountdown = 3f;
    public int counter;
    public int successesTarget;
    private int force;
    private float xmin;
    private float xmax;
    private float ymin;
    private float ymax;
    private bool pause = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //ShootingGallery(900,0f,2f,-2f,2f);
        //ShootingGallery(1000,0f,3f,0f,4f);
        //ShootingGallery(1100,0f,3f,-1f,3f);
        //ShootingGallery();
        monsterShooting();
    }

    public void setShootingParameters(int Counter, int Force, float Xmin, float Xmax, float Ymin, float Ymax)
    {
        counter = Counter;
        startCountdown = Random.Range(2f, 5f);
        force = Force;
        xmin = Xmin;
        xmax = Xmax;
        ymin = Ymin;
        ymax = Ymax;
    }


    void ShootingGallery()
    {
        if (!pause)
        {
            startCountdown -= Time.deltaTime;
            if (startCountdown < 0)
            {
                spawnTimer -= Time.deltaTime;
                if (spawnTimer <= 0 && counter > 0)
                {
                    spawnTimer = spawnRate;
                    Vector3 spawnPosition = transform.position;
                    spawnPosition.x += Random.Range(xmin, xmax);
                    spawnPosition.y += Random.Range(ymin, ymax);
                    Rigidbody target;
                    target = Instantiate(targetPrefab, spawnPosition, transform.rotation);
                    target.AddForce(transform.forward * force);
                    counter--;
                }
            }
        }
    }

    void monsterShooting()
    {
      //  if (!pause)
      //  {
            startCountdown -= Time.deltaTime;
            if (startCountdown < 0)
            {
                spawnTimer -= Time.deltaTime;
                if (spawnTimer <= 0)
                {
                    spawnTimer = spawnRate;
                    Vector3 spawnPosition = transform.position;
                    spawnPosition.y += Random.Range(-4f, 4f);
                    spawnPosition.z += Random.Range(-10f, 10f);
                    Rigidbody target;
                    target = Instantiate(rockPrefab, spawnPosition, transform.rotation);
                    counter--;
                }
            }
      //  }
    }

    public void pauseGame()
    {
        pause = true;
    }

    public void unPauseGame()
    {
        pause = false;
    }

    void Boars()
    {
        spawnTimer -= Time.deltaTime;
        startCountdown -= Time.deltaTime;
        if (startCountdown > 0)
        {
            if (spawnTimer <= 0)
            {
                spawnTimer = spawnRate;
                Vector3 spawnPosition = transform.position;
                spawnPosition.z -= Random.Range(0f, 10f);
                Instantiate(prefab, spawnPosition, transform.rotation);
            }
        }
        else
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>().StopShootingGame();
        }
    }
}