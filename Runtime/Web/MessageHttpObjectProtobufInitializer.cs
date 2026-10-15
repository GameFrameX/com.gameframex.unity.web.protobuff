using ProtoBuf.Meta;

namespace GameFrameX.Web.ProtoBuff.Runtime
{
    /// <summary>
    /// MessageHttpObject 的 protobuf-net 契约注册器，在 Unity 运行时加载时注册字段映射（Id=1，UniqueId=2，Body=3）。
    /// </summary>
    /// <remarks>
    /// 字段号与服务端 HTTP 网关的线格式契约一致，不可变更。
    /// </remarks>
    [UnityEngine.Scripting.Preserve]
    public static class MessageHttpObjectProtobufInitializer
    {
        /// <summary>
        /// 注册 MessageHttpObject 的 protobuf-net 元数据，须在首次 HTTP ProtoBuf 请求前执行。
        /// </summary>
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize()
        {
            var model = RuntimeTypeModel.Default;
            var type = typeof(MessageHttpObject);
            if (model.CanSerialize(type))
            {
                return;
            }

            var metaType = model.Add(type, false);
            metaType.Add(1, nameof(MessageHttpObject.Id));
            metaType.Add(2, nameof(MessageHttpObject.UniqueId));
            metaType.Add(3, nameof(MessageHttpObject.Body));
        }
    }
}
