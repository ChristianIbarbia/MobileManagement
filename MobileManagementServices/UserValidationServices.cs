using MobileManagementServices;

namespace AccountManagementServices
{
    public class UserValidationServices
    {

        UserGetServices getservices = new UserGetServices();

        public bool CheckIfUserNameExists(string brand)
        {
            bool result = getservices.GetUser(brand) != null;
            return result;
        }

        public bool CheckIfUserExists(string brand, string model,string price)
        {
            bool result = getservices.GetUser(brand,model,price) != null;
            return result;
        }

    }
}