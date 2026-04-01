using System;
using System.Collections.Generic;
using System.Text;

namespace Library_managment
{
    internal class SearchAboutMember
    {
        public List<Member> members;

        public SearchAboutMember(List<Member> members)
        {
            this.members = members;
        }


        public Member? SearchByName(string name)
        {

            foreach (Member member in members)
            {

                if (member.Name != null && member.Name.ToLower().Equals(name.ToLower()))
                {
                    return member;
                }
            }
            return null;

        }
    }
}
