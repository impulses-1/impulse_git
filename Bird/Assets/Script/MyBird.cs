﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBird : Bird
{
    public override void showSkill()
    {
        base.showSkill();
        rg.velocity *= 2;
    }
}
