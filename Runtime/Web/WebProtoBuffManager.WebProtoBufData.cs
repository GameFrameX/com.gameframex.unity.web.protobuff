using System.Threading.Tasks;
using GameFrameX.Runtime;
using GameFrameX.Web.Runtime;

namespace GameFrameX.Web.ProtoBuff.Runtime
{
    public partial class WebProtoBuffManager
    {
        /// <summary>
        /// Web ProtoBuf请求数据类，用于处理Protocol Buffer格式的Web请求
        /// </summary>
        private sealed class WebProtoBufData : WebManager.WebData
        {
            /// <summary>
            /// 获取请求任务的完成源，用于异步操作的控制和结果返回
            /// </summary>
            public TaskCompletionSource<WebBufferResult> Task { get; private set; }

            /// <summary>
            /// 获取要发送的Protocol Buffer序列化后的字节数组数据
            /// </summary>
            public byte[] SendData { get; private set; }

            /// <summary>
            /// 无参构造函数（ReferencePool 需要new约束）
            /// </summary>
            public WebProtoBufData() { }

            /// <summary>
            /// 创建Web ProtoBuf请求数据
            /// </summary>
            public static WebProtoBufData Create(string url, byte[] sendData, TaskCompletionSource<WebBufferResult> task, object userData)
            {
                var data = ReferencePool.Acquire<WebProtoBufData>();
                data.URL = url;
                data.IsGet = false;
                data.UserData = userData;
                data.Task = task;
                data.SendData = sendData;
                return data;
            }

            public override void Clear()
            {
                if (Task != null)
                {
                    Task.TrySetCanceled();
                    Task = null;
                }

                SendData = null;
                base.Clear();
            }
        }
    }
}
