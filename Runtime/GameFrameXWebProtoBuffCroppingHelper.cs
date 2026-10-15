using UnityEngine;

namespace GameFrameX.Web.ProtoBuff.Runtime
{
    [UnityEngine.Scripting.Preserve]
    public class GameFrameXWebProtoBuffCroppingHelper : MonoBehaviour
    {
        [UnityEngine.Scripting.Preserve]
        private void Start()
        {
            _ = typeof(WebProtoBuffComponent);
            _ = typeof(IWebProtoBuffManager);
            _ = typeof(WebProtoBuffManager);
            _ = typeof(MessageHttpObject);
        }
    }
}