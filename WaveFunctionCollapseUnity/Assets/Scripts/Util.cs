﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaveFunctionCollapse.Shared;

namespace WaveFunctionCollapse.Unity
{
    public class UnityLog : ISharedLogger
    {
        public void Log(object message)
        {
            Debug.Log(message);
            
        }
    }

    public static class Utlil
    {
        public static Random RandomGenerator = new Random();
    }
}
