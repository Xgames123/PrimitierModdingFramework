using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PrimitierModdingFramework
{

    public class PMFHelper
    {
        /// <summary>
        /// The system transform is used to store gameobjects that don't require saving (Custom objects that are not Cubes)
        /// </summary>
        public static Transform SystemTransform;


        public static void OnSceneLoad()
		{
            SystemTransform = GameObject.Find("System").transform;

		}

    }
}
