﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QCode
{
    public static partial class TransformExtension
    {
        /// <summary>
        /// 重置transform
        /// </summary>
        /// <param name="transform"></param>
        public static void Identity(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localScale = Vector3.one;
            transform.localRotation = Quaternion.identity;
        }
        public static void SetLocalPosX(this Transform transform,float x)
        {
            var localPos = transform.localPosition;
            localPos.x = x;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosY(this Transform transform, float y)
        {
            var localPos = transform.localPosition;
            localPos.y = y;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosZ(this Transform transform, float z)
        {
            var localPos = transform.localPosition;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosXY(this Transform transform, float x,float y)
        {
            var localPos = transform.localPosition;
            localPos.x = x;
            localPos.y = y;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosXZ(this Transform transform, float x, float z)
        {
            var localPos = transform.localPosition;
            localPos.x = x;
            localPos.z = z;
            transform.localPosition = localPos;
        }

        public static void SetLocalPosYZ(this Transform transform, float y, float z)
        {
            var localPos = transform.localPosition;
            localPos.z = z;
            localPos.y = y;
            transform.localPosition = localPos;
        }
    }
}