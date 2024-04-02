using UnityEngine;

namespace UnityEngine
{
    public class UnetMock
    {

    }

    public class NetworkView : MonoBehaviour
    {
        public NetworkViewID viewID;
        public bool isMine;

        public void RPC(string one, RPCMode two, object num1 = null, object num2 = null, object num3 = null, object num4 = null, object num5 = null, object num6 = null, object num7 = null)
        {

        }
    }

    public enum RPCMode
    {
        All,
        AllBuffered,
        Server
    }

    public class RPC : System.Attribute
    {
        public RPC()
        {
        }
    }

    public static class Network
    {
        public static bool isServer;
        public static bool isClient;
        public static int minimumAllocatableViewIDs;
        public static object[] connections;
        public static double time;

        public static Object Instantiate(Object prefab, Vector3 position, Quaternion rotation, int group)
        {
            return null;
        }

        public static void InitializeServer(int num, int port, bool nat)
        {

        }

        public static void Connect(string ip, int port)
        {

        }

        public static void RemoveRPCs(object id)
        {

        }

        public static void Destroy(NetworkViewID id)
        {

        }

        public static void Destroy(GameObject id)
        {

        }

        public static void DestroyPlayerObjects(object id)
        {

        }

        public static void Disconnect()
        {

        }

        public static void CloseConnection(NetworkPlayer p, bool sendDisconnectionNotification)
        {

        }

        public static bool HavePublicAddress()
        {
            return false;
        }
    }

    public class NetworkPlayer
    {
        public string ipAddress;
        public string port;
    }

    public static class MasterServer
    {
        public static void UnregisterHost()
        {

        }
    }

    public class NetworkViewID
    {

    }

    public class NetworkMessageInfo
    {
        public double timestamp;
    }

    public class BitStream
    {
        public bool isWriting;

        public void Serialize(ref Vector3 any)
        {
        }

        public void Serialize(ref Quaternion any)
        {

        }

        public void Serialize(ref float any)
        {

        }
    }

}

