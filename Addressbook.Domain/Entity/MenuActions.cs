using System;
using Addressbook.Domain.Common;

namespace Addressbook.Domain.Entity
{
    public class MenuActions : BaseEntity
    {
        public string Name { get; set; }

        public MenuActions(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
