using MobileManagementData;
using MobileManagementModels;

namespace MobileManagementServices
{
    public class UserTransactionServices
    {
        UserValidationServices validationServices = new UserValidationServices();
        UserData userData = new UserData();

        public bool CreateUser(User user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.brand))
            {
                result = userData.AddUser(user) > 0;
            }

            return result;
        }

        public bool CreateUser(string brand, string model, string price)
        {
            User user = new User { brand = brand, model = model, price = price };

            return CreateUser(user);
        }

        public bool UpdateUser(User user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.brand))
            {
                result = userData.UpdateUser(user) > 0;
            }

            return result;
        }

        public bool UpdateUser(string brand, string model, string price)
        {
            User user = new User { brand = brand, model = model, price = price };

            return UpdateUser(user);
        }

        public bool DeleteUser(User user)
        {
            bool result = false;

            if (validationServices.CheckIfUserNameExists(user.brand))
            {
                result = userData.DeleteUser(user) > 0;
            }

            return result;
        }
    }
}
