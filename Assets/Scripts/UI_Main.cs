using AC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Main : MonoBehaviour
{
    private AC.Menu inventoryMenu;

    void Start()
    {
        //IEnumerator Delay()
        //{
        //    yield return null;
        //    player = FindObjectOfType<Player>();
        //}

        //StartCoroutine(Delay());

        inventoryMenu = PlayerMenus.GetMenuWithName("Inventory");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();
        }
    }

    public void ToggleInventory()
    {
        if (inventoryMenu != null && !KickStarter.player.IsMovingAlongPath())
        {
            Animator Anim = FindObjectOfType<Player>().GetComponentInChildren<Animator>();

            if (inventoryMenu.IsOn())
            {
                inventoryMenu.TurnOff();
                Anim.SetBool("Inv_Open", false);
                PlayerMovementState(true);
            }
            else
            {
                inventoryMenu.TurnOn();
                Anim.SetBool("Inv_Open", true);
                PlayerMovementState(false);
            }
        }
    }

    void PlayerMovementState(bool Value)
    {
        KickStarter.stateHandler.SetMovementSystem(Value);
    }

    void FootPrefab()
    {
        
    }
}
