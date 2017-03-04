﻿using UnityEngine;

public class TestMouseInput : MonoBehaviour
{
    public ChatroomManager Chatroom;
    public HoverMenu HoverMenu;

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            HoverMenu.OpenMenu();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            HoverMenu.CloseMenu();
        }

        if(Input.GetMouseButtonDown(1))
        {
            string text = "Test message: ";
            for(int i = 0; i < Random.Range(0, 20); i++)
                text += "a ";
            Chatroom.AddMessage("Guy", text);
        }
    }
}
