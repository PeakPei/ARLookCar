/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class MyTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
        public string objectName;
        #region PRIVATE_MEMBER_VARIABLES

        private TrackableBehaviour mTrackableBehaviour;

        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            //获取所有TrackObject的物体并将他们都销毁
            TrackObject[] objects = FindObjectsOfType<TrackObject>();
            foreach (TrackObject to in objects ) {
                Destroy(to.gameObject);
            }
            //卸载无用资源
            Resources.UnloadUnusedAssets();
            //加载需要显示的模型并实例化到场景中
            GameObject obj= GameObject.Instantiate(Resources.Load(objectName)) as GameObject;
            //将父物体设置为ImageTarget
            obj.transform.SetParent(this.transform);
            //设置物体位置
            obj.transform.position = this.transform.position;
        }


        private void OnTrackingLost()
        {
            //从子物体中获取所有的TrackObject组件
            TrackObject to = GetComponent<TrackObject>();
            if (to != null) {
                //将物体的父对象从识别目标中移除
                to.transform.parent = this.transform.parent;
                //设置物体的layer值，这里用另一个Camera来渲染脱卡之后的模型
                to.gameObject.layer = 10;
                //物体的位置设置为TrackObejct脚本中设置好的位置
                to.transform.position = to.LostPosition;
            }
        }

        #endregion // PRIVATE_METHODS
    }
}
