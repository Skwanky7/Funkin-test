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
So you're gonna wanna create a new project, Name it anything BUT make sure you choose **2D** as a template.
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

### Open the C# script with Visual Studio Code, name it "IDFK" then do the following;
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
    public float cooldown = 0.5f;

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
public bool IsWorking;
```
wich is a list full of boolean character states. The ``IsWorking`` one is clear, it means if the Character is working (you're gonna wanna enable that in the inspector or nothing will work).

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
public float cooldown = 0.5f;
```
A character state cooldown. (when you click W, A, S or D, those buttons won't function until 0.5 seconds pass. Don't change it you fool)

---------------
- **Is in state**
```cs
if(IsIdle)
{
     IdleSprite.SetActive(true);
     UpSprite.SetActive(false);
     DownSprite.SetActive(false);
     LeftSprite.SetActive(false);
     RightSprite.SetActive(false);
}
```
This is an example of a boolean state, the ``if(IsIdle)`` means *if the character is idle*, same goes for all the others and what it does is that when the character is on idle, All the Up, Down, Left and Right sprites are deactivated (``Down/Left/Up/RightSprite.SetActive(false);``) and only the Idle sprite is activated (``IdleSprite.SetActive(true);``).


- **Is Working**
```cs
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
```
What this does is it checks whether the ``IsWorking`` boolean is on or not, if so, when you click W, A, S or D (``if(Input.GetKeyDown(KeyCode.W/A/S/D))``) it's gonna play a certain node like Up for W, down for S etc.


- **Node Function**
```cs
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
```
And last but not least, this is an example of a Node Function, what it does is it deactivates boolean states that aren't needed, then waits for the cooldown time (``yield return new WaitForSeconds(cooldown);``) then reactivates them.


## Final touches
So after you finished reading and following all the steps above, go back to Unity and create a Folder and call it ``CharacterSprites``. Import all your sprites into it (they must be the same size and each one should be a png, not a gif. They're not supported on unity either way.) I'll just use the Tricky ones cuz i like madness combat.
<br>
<img height ="300" src="https://cdn.discordapp.com/attachments/827853989541576704/827922246579257374/unknown.png">
</br>

Then drag and drop a single frame from every node into the Empty GameObject "GameObject" in the Hierarchy. Set their position on the X, Y and Z axis to 0 and adjust the scale to whatever you want.

Go to ``Windows > Animation > Animation`` wich will open a new Tab called Animation (duh).
<br>
<img height ="300" src="https://cdn.discordapp.com/attachments/827853989541576704/827925127093813338/unknown.png">
</br>

Click on a random sprite (keep it active) and deactivate all the others by going through each one of them all and clicking the button near their names on the inspector (click it again to enable), then start animating the one that isn't disabled by selecting it, going to the Animation tab and clicking on Create And naming the animation whatever (for example UpNode if the random sprite is for the up node.), click on the red button near the preview button then drag and drop all the other animation frames for the coresponding sprite into the animation tab. that'll make kind of an animation. For More detail watch this: https://www.youtube.com/watch?v=BlalhxSTUWo

Once you're done with that one, you can disable and enable another sprite aaand continue the process with every single sprite. (Up, down, left and right)

once you're done, select the Empty Object and drag and drop every single one of them from the hierarchy into the slots in the inspector.
<br>
<img height ="100" src="https://cdn.discordapp.com/attachments/827853989541576704/827944125155246140/unknown.png">
</br>

After that, drag and drop your character sounds to the Project tab (the CharacterSprites folder to be specific) and select the empty gameobject in the hierarchy tab then drag and drop the audio clips into the empty slots. Right click in the hierarchy tab > Audio > AudioSource And finaly drag and drop that AudioSource into the Audio S slot in the GameObject's Inspector.

For the Background, import it into the character sprites folder, then drag it into the scene tab and adjust the position to fit the screen.

### Before you test the game, turn the IsWorking and IsIdle boolean on and disable all the others then start.

It should look something like this (but without the camera movement and with your sprites);

<img src="https://cdn.discordapp.com/attachments/827853989541576704/827959278111162368/aeai.gif" height="300" />

Camera movements upcoming in the next Document Version. (i'm in a hurry sorry lol)


<sup><sub> A document writen by SaneMan. </sub></sup>
