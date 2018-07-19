using System.Collections.Generic;

namespace Google.Common.Constants
{
    public static class RoleNames
    {
        public const string Admin = "Admin";

        public const string User = "User";

        public static readonly IReadOnlyList<string> All = new List<string> { Admin, User };
    }
}