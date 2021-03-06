﻿
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    public class Family
    {
        private readonly HashSet<Person> members;
        public Family()
        {
            this.members = new HashSet<Person>();
        }
        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldestPerson = this.members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();
            return oldestPerson;
        }
        public HashSet<Person> GetAllPeopleAbove30()
        {
            return this.members.Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToHashSet();
        }
    }
}
