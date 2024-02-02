using BusinessObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace DataAccess
{
    public class MemberDAO
    {
        // Initialize MemberList
        private static List<MemberObject> members = new List<MemberObject>
        {
            new MemberObject(2,"Tung", "tung@gmail.com", "123456", "Thai Nguyen", "Viet Nam"),
            new MemberObject(3,"Tam", "tam@gmail.com", "abcxyz", "Thanh Hoa", "Viet Nam"),
            new MemberObject(4,"Duc", "duc@gmail.com", "12345678", "Thanh Hoa", "Viet Nam"),
            new MemberObject(5,"Dat", "dat@gmail.com", "123456789", "Bac Ninh", "Viet Nam" ),
            new MemberObject(6,"Kyle", "kyle@gmail.com", "kyle12333", "Berlin", "Germany"),          
            new MemberObject(7,"Messi", "messi@gmail.com", "6h50", "Buenos Aires", "Argentina"),
            new MemberObject(8,"Ronaldo", "ronaldo@gmail.com", "9h53", "Lisbon", "Portugal")          
        };
        private MemberDAO()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminEmail = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];
            members.Add(new MemberObject(1, "Admin", adminEmail, adminPassword, "Ha Noi", "Viet Nam"));
        }

        // Using Singleton Pattern
        private static MemberDAO instance = null;
        private static object instanceLook = new object();

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public List<MemberObject> GetMembersList => members;

        public MemberObject Login(string Email, string Password)
        {
            //MemberObject member = new MemberObject();
            //member = members.SingleOrDefault(mb => mb.Email.Equals(Email) && mb.Password.Equals(Password));
            //return member;

            if (members != null)
            {
                foreach (var member in members)
                {
                    if (member != null && member.Email == Email && member.Password == Password)
                    {
                        return member; // Trả về thành viên nếu tìm thấy
                    }
                }
            }
            return null;
        }

        public MemberObject GetMember(int MemberId)
        {
            return members.SingleOrDefault(mb => mb.MemberID == MemberId);
        }
        public MemberObject GetMember(string MemberEmail)
        {
            return members.SingleOrDefault(mb => mb.Email.Equals(MemberEmail));
        }
        public void AddMember(MemberObject member)
        {
            if (member == null)
            { 
                throw new Exception("Member is undefined!!");
            }

            if (GetMember(member.MemberID) == null && GetMember(member.Email) == null)
            {
                members.Add(member);
            }
            else
            {
                throw new Exception("Member is existed!!");
            }
        }
        public void Update(MemberObject member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!");
            }
            MemberObject mem = GetMember(member.MemberID);
            if (mem != null)
            {
                var index = members.IndexOf(mem);
                members[index] = member;
            }
            else
            {
                throw new Exception("Member does not exist!!");
            }
        }
        public void Delete(int MemberId)
        {
            MemberObject member = GetMember(MemberId);
            if (member != null)
            {
                members.Remove(member);
            }
            else
            {
                throw new Exception("Member does not exist!!");
            }
        }

        public IEnumerable<MemberObject> SearchMember(int id)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in members
                               where member.MemberID == id
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }
        public IEnumerable<MemberObject> SearchMember(string name)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in members
                               where member.MemberName.ToLower().Contains(name.ToLower())
                               select member;
            searchResult = memberSearch;

            return searchResult;
        }

        public IEnumerable<MemberObject> FilterMemberByCountry(string country, IEnumerable<MemberObject> searchList)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in searchList
                               where member.Country == country
                               select member;
            if (country.Equals("All"))
            {
                memberSearch = from member in searchList
                               select member;
            }
            searchResult = memberSearch;

            return searchResult;
        }

        public IEnumerable<MemberObject> FilterMemberByCity(string country, string city, IEnumerable<MemberObject> searchList)
        {
            IEnumerable<MemberObject> searchResult = null;

            var memberSearch = from member in searchList
                               where member.City == city
                               select member;
            if (city.Equals("All"))
            {
                memberSearch = from member in searchList
                               where member.Country == country
                               select member;
                if (country.Equals("All"))
                {
                    memberSearch = from member in searchList
                                   select member;
                }
            }
            searchResult = memberSearch;

            return searchResult;
        }
    }



    
}
