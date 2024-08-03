

namespace MobileManagementModels
{
    public class User
    {
        public string brand;
        public string model;
        public string price;
        public DateTime dateVerified;
        private DateTime dateCreated = DateTime.Now;
        public DateTime dateUpdated;
        public int status;
        public string username;
    }

}
