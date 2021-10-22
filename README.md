# Bermuda_NightFiver

![Bermuda NightFiver](https://img.itch.zone/aW1nLzcxMzMzMTMucG5n/original/rPRRSr.png)

Bermuda NightFiver is a little 2D game made with Unity by 8 students during the ludum dare 49 on the 2nd of october 2021. 

You can find it on [Itch.io](https://dratsok.itch.io/bermuda-night-fever) if you want to try it.

## Core Gameplay - Déplacement


For the deplacement we use a grid of 6 by 6 named "plateau" :

```Csharp

    public static Vector2[,] plateau = new Vector2[GameManager.taillePlateau, GameManager.taillePlateau];

    private void Start()
    {
        //add each coordinate in each part of the table 
        for (int i = 0; i < GameManager.taillePlateau; i++)
        {
            for (int j = 0; j < GameManager.taillePlateau; j++)
            {
                plateau[i, j] = new Vector2(i, j);
            }
        }
    }
```
![grid](https://media.discordapp.net/attachments/892742039400235029/900872699499388928/unknown.png)

In order to move the player, We can just move him in this grid by adding or removing 1 in the X axis or the Y axis if he is still in range.(there is only the négative one here)

```csharp
if (Input.GetKeyDown(KeyboardManager.keyUp))
{
    if (playerPositionY != GameManager.taillePlateau - 1)//check if we're still in range
    {
        playerPosition.position = PlateauManager.plateau[(int)playerPositionX, (int)playerPositionY + 1];
        playerPositionY++;
    }
}

else if (Input.GetKeyDown(KeyboardManager.keyRight))
{
    if (playerPositionX != GameManager.taillePlateau - 1)//check if we're still in range
    {
        playerPosition.position = PlateauManager.plateau[(int)playerPositionX + 1, (int)playerPositionY];
        playerPositionX++;
    }
}
```


## Core Gameplay - Mini games

For this game we wannted to add many mini games in order to shuffle them

With this in mind all we have to do is to create each mini games an randomly choose one of them to be played

```csharp
int miniGame = Random.Range(0, 5);
```

In the First mini game you have to dodge the hole and reach the flag
![reach the flag](https://media.discordapp.net/attachments/892742039400235029/900887974651248690/unknown.png?width=1202&height=676)

In the second, you have to collect all the bottles
![bottle](https://media.discordapp.net/attachments/892742039400235029/900888038593429614/unknown.png?width=1203&height=676)

In the third one, you have to run away from deadly case and survive
![survive](https://media.discordapp.net/attachments/892742039400235029/900888132994629732/unknown.png?width=1202&height=676)

In the fourth one, you have to kill the enemy
![kill the enemy](https://media.discordapp.net/attachments/892742039400235029/900888208517255218/unknown.png?width=1202&height=676)

With this base we can now add modifier and just using one goal that will be write on the top right of the screen

```csharp
if (score > 10)
{
    fier1 = Random.Range(0, 7);
    e (modifier1 == tableau)
    
    modifier1 = Random.Range(0, 7);
    
}
```

and we play every minigames who was called with the objectif

```csharp
if (tableau == 0 || modifier1 == 0 || modifier2 == 0)//trou
{
     TableauAtoBSystem.instance.ActivateGame();
     if (tableau == 0)
     {
         TableauAtoBSystem.instance.ActiveVictory();
         objectifText.text = "Reach the flag";
     }
}
````

Now we have multiple mini game at once, here there is the bottle and the flag mini games but the goal is to reach the flag
![multiple](https://media.discordapp.net/attachments/892742039400235029/900888840640806943/unknown.png?width=1202&height=676)

We can also add modifier like this light(it moves from left to right)
![light modifier](https://media.discordapp.net/attachments/892742039400235029/900888910090100807/unknown.png?width=1202&height=676)




