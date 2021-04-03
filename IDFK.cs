using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDFK : MonoBehaviour
{
    [Header("Bool shit")]
    public bool IsIdle;
    public bool UpNode;
    public bool DownNode;
    public bool LeftNode;
    public bool RightNode;

    public bool IsWorking;

    [Header("sprites")]
    public GameObject IdleSprite;
    public GameObject UpSprite;
    public GameObject DownSprite;
    public GameObject LeftSprite;
    public GameObject RightSprite;

    [Header("audio stuff")]
    public AudioSource AudioS;
    public AudioClip UpSound;
    public AudioClip DownSound;
    public AudioClip LeftSound;
    public AudioClip RightSound;

    [Header("values")]
    public float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        IsIdle = true;
        UpNode = false;
        DownNode = false
        RightNode = false;
        LeftNode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsIdle)
        {
            IdleSprite.SetActive(true);
            UpSprite.SetActive(false);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(false);
        }

        if(UpNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(true);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(false);
        }

        if(DownNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(false);
            DownSprite.SetActive(true);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(false);
        }

        if(LeftNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(false);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(true);
            RightSprite.SetActive(false);
        }

        if(RightNode)
        {
            IdleSprite.SetActive(false);
            UpSprite.SetActive(false);
            DownSprite.SetActive(false);
            LeftSprite.SetActive(false);
            RightSprite.SetActive(true);
        }




        

        if(IsWorking)
        {
            if(Input.GetKeyDown(KeyCode.W))
        {
            AudioS.PlayOneShot(UpSound);
            StartCoroutine(UpNod());
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            AudioS.PlayOneShot(LeftSound);
            StartCoroutine(LeftNod());
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            AudioS.PlayOneShot(DownSound);
            StartCoroutine(DownNod());
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            AudioS.PlayOneShot(RightSound);
            StartCoroutine(RightNod());
        }

        }

        
    }

    IEnumerator UpNod()
    {
        IsIdle = false;
        UpNode = true;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;
    }

    IEnumerator DownNod()
    {
        IsIdle = false;
        UpNode = false;
        DownNode = true;
        LeftNode = false;
        RightNode = false;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;
    }

    IEnumerator LeftNod()
    {
        IsIdle = false;
        UpNode = false;
        DownNode = false;
        LeftNode = true;
        RightNode = false;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;
    }

    IEnumerator RightNod()
    {
        IsIdle = false;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = true;
        IsWorking = false;
        yield return new WaitForSeconds(cooldown);
        IsIdle = true;
        UpNode = false;
        DownNode = false;
        LeftNode = false;
        RightNode = false;
        IsWorking = true;

    }

}
