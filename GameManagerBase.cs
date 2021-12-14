using System;
using UnityEngine;
using WW.Patterns;

namespace WW.Utilities
{
    /// <summary>
    /// Base class for a game manager
    /// </summary>
    public class GameManagerBase : Singleton<GameManagerBase>
    {
        /// <summary>
        /// Time the play session starts
        /// </summary>
        private DateTime sessionStartTime;
        /// <summary>
        /// Time the play session ends
        /// </summary>
        private DateTime sessionEndTime;

        /// <summary>
        /// Record session start time
        /// </summary>
        protected void Start()
        {            
            sessionStartTime = DateTime.Now;

            Debug.Log("Game session started at: " + DateTime.Now);
        }

        /// <summary>
        /// Before exitting output play session length
        /// </summary>
        protected void OnApplicationQuit()
        {
            sessionEndTime = DateTime.Now;
            TimeSpan timeDifference = sessionEndTime.Subtract(sessionStartTime);

            Debug.Log("Game session ended at: " + DateTime.Now);
            Debug.Log("Game session lasted: " + timeDifference);
        }
    }
}