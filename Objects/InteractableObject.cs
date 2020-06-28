﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InteractableObject
{
    void interact();
    string getTooltip();
}