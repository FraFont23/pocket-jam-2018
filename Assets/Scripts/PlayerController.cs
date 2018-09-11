﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : AIAgentController
{
    void Awake()
    {
        GameManager.Instance.PlayerController = this;
    }
}
