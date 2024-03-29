﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Added successfully.";
        public static string InvalidAdd = "Can not be added.";

        public static string Updated = "Updated successfully.";
        public static string InvalidUpdate = "Can not be updated.";

        public static string Listed = "Listed successfully.";
        public static string InvalidList = "Can not be listed.";

        public static string Deleted = "Deleted successfully.";
        public static string InvalidDelete = "Can not be deleted.";

        public static string Maintenance = "Can't do any operations due to maintenance.";

        public static string ImageAdded = "Image added successfully;";
        public static string ImageNumberExceeded = "A car can't have more than 5 images.";
        public static string AuthorizationDenied = "Auth denied.";
        public static string AccessTokenCreated = "Access token created.";
        public static string UserRegistered = "Registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Wrong Password";
        public static string SuccessfulLogin = "Logged in.";
        public static string UserAlreadyExists = "This user already exists.";
    }
}
