using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using PixelCrushers.DialogueSystem;
using PixelCrushers.DialogueSystem.Articy.Articy_1_4;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject rockPrefab;
    private float spawnRate = 2f;
    private float spawnTimer = 0;
    private float startCountdown = 3f;
    public int counterInitial;
    public int counter;
    public int successesTarget;
    public int force;
    public float xmin;
    public float xmax;
    public float ymin;
    public float ymax;
    private bool pause = false;
    public GameObject retry;
    private ManagerScript manager;

    // Use this for initialization
    void Start()
    {
        //setShootingParameters(20,30,0f,3f,0f,4f);
        counter = counterInitial;
        manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ManagerScript>();
        manager.ItemsShot = 0;
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
        startCountdown = Random.Range(4f, 6f);
        force = Force;
        xmin = Xmin;
        xmax = Xmax;
        ymin = Ymin;
        ymax = Ymax;
    }

    void monsterShooting()
    {
        if (!pause && counter >= 0)
        {
            startCountdown -= Time.deltaTime;
            if (startCountdown < 0)
            {
                spawnTimer -= Time.deltaTime;
                if (spawnTimer <= 0)
                {
                    spawnTimer = spawnRate;
                    Vector3 spawnPosition = transform.position;
                    spawnPosition.x += Random.Range(xmin, xmax);
                    spawnPosition.y += Random.Range(ymin, ymax);
                    GameObject target;
                    target = Instantiate(rockPrefab, spawnPosition, transform.rotation);
                    target.GetComponent<EnemyCharge>().speed = force;
                    counter--;
                }
            }
        }
        if (counter < 0)
        {
            retry.SetActive(true);
        }
    }

    public void reset()
    {
        counter = counterInitial;
        startCountdown = Random.Range(4f, 6f);
        spawnTimer = 0;
        manager.ItemsShot = 0;
        retry.SetActive(false);
        //reset position?
    }

    public void pauseGame()
    {
        pause = true;
    }

    public void unPauseGame()
    {
        pause = false;
    }
}