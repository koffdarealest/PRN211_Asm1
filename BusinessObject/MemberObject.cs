using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class MemberObject
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (IsEmail(value))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Wrong format for Email!!");
                }

            }
        }

        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public static bool IsEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

        public MemberObject(int memberID, string memberName, string email, string password, string city, string country)
        {
            MemberID = memberID;
            MemberName = memberName;
            Email = email;
            Password = password;
           City = city;
            Country = country;
        }

        public MemberObject()
        {
        }
    }

    
}