# Friday night funkin' Test development
Okay so let me get to the point, This is a document demonstrating Every step and requirement you gotta follow to be able to make a Friday night funkin test. It may seem complex but just bare with me.

## Requirements:
- Windows 7 or more
- 64bit computer
- [Visual Studio Code](https://code.visualstudio.com/download)
- [Unity 2019](https://unity3d.com/get-unity/download)

If you don't know how to download Unity or VScode;
> "it can be solved with a simple google search"
-bbpanzu

## Project Set up:
So you're gonna wanna create a new project, Name i anything BUT make sure you choose **2D** as a template.
<br>
<img height ="400" src="https://cdn.discordapp.com/attachments/827853989541576704/827883851468636160/unknown.png">
</br>

Once the project is created, Right click in the Projects Tab, Then ```Create > Folder```
<br>
<img height ="200" src="https://cdn.discordapp.com/attachments/827853989541576704/827886137599197194/unknown.png">
</br>

You can Name it anything, In my case, it's gonna be called "Scripts".

Click on the Scene Tab and zoom into the camera using the mouse wheel.
<br>
<img height ="400" src="https://cdn.discordapp.com/attachments/827853989541576704/827889796956553236/unknown.png">
</br>

So once that's all done, you'll have to go to the Hierarchy Tab, ```Right click > Create Empty.```

click on the Empty Object "GameObject" on the Hierarchy then Click W. 2 arrows should appear in the middle of the screen.
Okay so after that's done, go to the Project tab, double click on the Script folder, then ```right click > Create > C# script``` And Name it anything.
<br>
<img height ="200" src="https://cdn.discordapp.com/attachments/827853989541576704/827891672888246272/unknown.png">
</br>

### Open the C# script with Visual Studio Code, then do the following;
Erase all the code then Copy and Paste this in
```cs
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
```
Now this might be lookin' kinda scary but don't worry, it's an easy script and there must be no error (if there are any, report them to me here: https://discord.gg/5qvESRHEBx)

Alrighty, save and go back to Unity and click on the Empty object "GameObject" and drag and drop the script into it's inspector.

It should look like this:
<br>
<img height ="400" src="https://cdn.discordapp.com/attachments/827853989541576704/827900805196939335/unknown.png">
</br>

## How it works:
Ooookay, Let me explain what this does. (you can skip if you want but i'd recommend you read so you know what you're doing)

So, the script is basicaly everything needed for the test to work.

- **Character states**
```cs
public bool IsIdle;
public bool UpNode;
public bool DownNode;
public bool LeftNode;
public bool RightNode;
```
wich is a list full of boolean character states.

- **Sprites**
```cs
public GameObject IdleSprite;
public GameObject UpSprite;
public GameObject DownSprite;
public GameObject LeftSprite;
public GameObject RightSprite;
```
Those are the Sprites you're gonna be using in-game.

- **Audio Sources and Clips**
```cs
public AudioSource AudioS;
public AudioClip UpSound;
public AudioClip DownSound;
public AudioClip LeftSound;
public AudioClip RightSound;
```
Character sound effects and sources.

- **cooldown**
```cs
public float cooldown;
```
A character state cooldown.




