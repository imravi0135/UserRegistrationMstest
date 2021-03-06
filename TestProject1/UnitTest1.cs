using NUnit.Framework;
using System;
using UserRegistrationMstest;

namespace UserRegistrationTest
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void ValidFirst()
        {
            string expected = "First Name is Valid";
            string name = "Ravi";
            string result = validation.ValidFirstName(name);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ValidLastName()
        {
            string expected = "Last Name is Valid";
            string name = "Kishore";
            string result = validation.ValidLastName(name);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ValidEmail()
        {
            string expected = "Email is Valid";
            string result = null;
            string email = "Ravikishore@gmail.com";
            try
            {
                result = validation.ValidEmail(email);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPhone()
        {
            string expected = "Phone number is Valid";
            string result = null;
            try
            {
                string phone = "9374738446";
                result = validation.ValidPhoneNumber(phone);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters";
            try
            {
                string password = "password";
                result = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord_2()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters and one UpperCase";
            try
            {
                string password = "passwords";
                result = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord_3()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters,one Upper Case and one number";
            try
            {
                string password = "passwords";
                result = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
        [Test]
        public void ValidPassWord_4()
        {
            string result = null;
            string expected = "Password should contain atleast eight characters,one Upper Case, one number and one special character";
            try
            {
                string password = "passwords";
                result = validation.ValidPasswordEightChars(password);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, result);
            }
        }
    }
}