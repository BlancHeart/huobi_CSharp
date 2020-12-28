using System.Text.Json.Serialization;

namespace Huobi.SDK.Model.Request.SubUser
{
    /// <summary>
    /// Create SubUser request
    /// </summary>
    public class CreateSubUserRequest
    {
        public UserList[] userList;

        public class UserList
        {
            public string userName;

            public string note;
        }
    }
}
