using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{

    public int CurrentSpeed;
    public Transform x, y, z;
    public float Speed;
    Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
    }


    void OnTriggerEnter(Collider otherObject)

    {
        if (otherObject.tag == "Respawn")
        {
            StartCoroutine(ChangeScene());
        }

    }

    IEnumerator ChangeScene()

    {
        rend.enabled = false;
        yield return new WaitForSeconds(3f);
        rend.enabled = true;
        SceneManager.LoadScene(2);
    }


}