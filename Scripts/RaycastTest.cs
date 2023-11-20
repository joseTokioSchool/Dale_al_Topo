using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] AudioSource moleSource;
    [SerializeField] AudioClip moleClip;
    void Start()
    {
        cam = Camera.main;
        moleSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay( Input.mousePosition );
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 10f))
            {
                if (hit.collider.gameObject.layer == 3)
                {
                    moleSource.PlayOneShot(moleClip);
                    Destroy(hit.collider.gameObject);
                    ScoreManager.scoreManagerInstance.AddScore();
                }
            }
            
        }
    }
}
