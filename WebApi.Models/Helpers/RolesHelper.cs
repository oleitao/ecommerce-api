using System.Runtime.Serialization;

namespace WebApi.Entities
{
    public static class RolesHelper
    {
        public const string User = "User";
        public const string Seller = "Seller";
        public const string Admin = "Admin";

        public const string UserNormalzed = "USER";
        public const string SellerNormalzed = "SELLER";
        public const string AdminNormalzed = "ADMIN";

        public const string RoleIdUser = "efbcf454-0125-41ff-ac91-75d1564af047";
        public const string RoleIdSeller = "efbcf454-0125-41ff-ac91-75d1564af048";
        public const string RoleIdAdmin = "efbcf454-0125-41ff-ac91-75d1564af049";

        public readonly static Dictionary<string, string> Users = new Dictionary<string, string>()
        {
            { RoleIdUser, UserNormalzed},
            { "profile","/profile" },
            { "profileSideBar","profile,orders,refunds,inbox,trackOrders,changePassword,address,logout"}
        };

        public readonly static Dictionary<string, string> Sellers = new Dictionary<string, string>()
        {
            { RoleIdSeller, SellerNormalzed},
            { "profile","/shop" },
            { "profileSideBar","profile,orders,refunds,inbox,trackOrders,changePassword,address,logout"}
        };

        public readonly static Dictionary<string, string> Admins = new Dictionary<string, string>()
        {
            { RoleIdAdmin, AdminNormalzed},
            { "profile","/profile-admin" },
            { "profileSideBar","profile,orders,refunds,inbox,changePassword,logout"}
        };
    }
}
