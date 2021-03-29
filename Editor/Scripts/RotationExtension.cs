using UnityEngine;

namespace ArchNet.Extension.Rotation
{
    /// <summary>
    /// [EXTENSION] - [ARCH NET] - [ROTATION] Extension to manage Gameobject to rotate
    /// author : LOUIS PAKEL
    /// </summary>
    public class RotationExtension : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField] private bool _isActive = false;
        [SerializeField] private float _speed;
        [SerializeField] private bool _forward;

        #endregion

        // Update is called once per frame
        void Update()
        {
            if(IsActive() == false)
            {
                return;
            }

            if (_forward == true)
            {
                this.transform.Rotate(Vector3.back * Time.deltaTime * _speed, Space.World);
            }
            else
            {
                this.transform.Rotate(Vector3.forward * Time.deltaTime * _speed, Space.World);
            }

        }

        #region Public Methods

        /// <summary>
        /// Description : set the active boolean value of the extension to true
        /// </summary>
        /// <param name="pValue"></param>
        public void ActiveExtension()
        {
            _isActive = true;
        }

        /// <summary>
        /// Description : set the active boolean value of the extension to false
        /// </summary>
        /// <param name="pValue"></param>
        public void DesactiveExtension()
        {
            _isActive = false;
        }

        /// <summary>
        /// Description : Check if the extension is active
        /// </summary>
        /// <returns></returns>
        public bool IsActive()
        {
            return _isActive;
        }

        /// <summary>
        /// Description : Set if the rotation goes forward or not
        /// </summary>
        /// <param name="pValue"></param>
        public void SetForward(bool pValue)
        {
            _forward = pValue;
        }

        #endregion
    }
}
