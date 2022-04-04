﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UserRegistrationMstest.UserRegistrationCustomException;

namespace UserRegistrationMstest
{
    public class Validation
    {
        public Regex FirstNameRegex = new Regex("^[A-Z]{1}[A-Za-z]{2,}$");
        public string ValidFirstName(string firstName)
        {
            bool result = false;
            if (FirstNameRegex.IsMatch(firstName)) { result = true; }
            try
            {
                if (result == false)
                {
                    if (firstName.Equals(string.Empty))
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Empty,
                            "First name should not be empty");
                    else if (firstName.Length < 3)
                        throw new UserValidationCustomException(UserValidationCustomException.ExceptionType.Name_Less_Than_Three,
                            "First name should contain atleast three character");
                }
                else
                {
                    return "First Name is Valid";
                }
            }
            catch (UserValidationCustomException exception)
            {
                throw exception;
            }
            return "First Name is Invalid";
        }
    }
}