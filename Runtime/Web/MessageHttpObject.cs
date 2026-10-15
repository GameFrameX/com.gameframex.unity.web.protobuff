using GameFrameX.Runtime;

namespace GameFrameX.Web.ProtoBuff.Runtime
{
    /// <summary>
    /// HTTP消息包装基类
    /// </summary>
    public class MessageHttpObject
    {
        /// <summary>
        /// 消息ID
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public int Id { get; set; }

        /// <summary>
        /// 消息序列号
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public int UniqueId { get; set; }

        [UnityEngine.Scripting.Preserve]
        [GameFrameX.LitJSON.Runtime.JsonIgnore]
        public byte[] Body { get; set; }

        public override string ToString()
        {
            return Utility.Json.ToJson(this);
        }
    }
}
